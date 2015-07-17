﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ShudderPT
{
    public partial class Main : Form
    {
        //Our ffmpeg process
        Process process = new Process();

        //FFMpeg flags
        string targetURL = "rtmp://stream.reblink.org/live/Reblink";
        string fileName = "";
        int[] startTime = { 0, 0, 0 };
        int vBit = 1000;
        int aBit = 196;
        int vRate = 30;
        int aRate = 44100;
        string vSize = "720x406";
        string vCodec = "libx264";
        string aCodec = "libmp3lame";
        bool paused = false;



        //Thread level kernal bullshit. I SHOULDN'T NEED THIS.
        [Flags]
        public enum ThreadAccess : int
        {
            TERMINATE = (0x0001),
            SUSPEND_RESUME = (0x0002),
            GET_CONTEXT = (0x0008),
            SET_CONTEXT = (0x0010),
            SET_INFORMATION = (0x0020),
            QUERY_INFORMATION = (0x0040),
            SET_THREAD_TOKEN = (0x0080),
            IMPERSONATE = (0x0100),
            DIRECT_IMPERSONATION = (0x0200)
        }

        [DllImport("kernel32.dll")]
        static extern IntPtr OpenThread(ThreadAccess dwDesiredAccess, bool bInheritHandle, uint dwThreadId);
        [DllImport("kernel32.dll")]
        static extern uint SuspendThread(IntPtr hThread);
        [DllImport("kernel32.dll")]
        static extern int ResumeThread(IntPtr hThread);

        delegate void updateTextCallback(string text);

        //Init form
        public Main()
        {
            InitializeComponent();
        }

        private void buttonStream_Click(object sender, EventArgs e)
        {
            StartStream();
            buttonPause.Enabled = true;
        }

        public void StartStream()
        {
            if (!isRunning())
            {
                //Our args for ffmpeg.
                string runArgs = " -re -y "
                    + "-ss " + string.Join(":", startTime) //Start time
                    + " -i \"" + fileName                  //File name
                    + "\" -vcodec " + vCodec               //Video codec
                    + " -b:v " + vBit + "k"                //Video bitrate
                    + " -r " + vRate                       //Video framerate
                    + " -bufsize " + vBit*2 +"k"           //Buffer size
                    + " -g " + vRate*2                     //GOP size
                    + " -s " + vSize                       //Video resolution
                    + " -filter:v yadif -acodec " + aCodec //Audio codec
                    + " -ab " + aBit + "k"                 //Audio bitrate
                    + " -ac 2"                             //Audio channels
                    + " -ar " + aRate                      //Audio sample rate
                    + " -f flv \"" + targetURL + "\"";     //Target url

                //Other
                int lineCount = 0;
                StringBuilder output = new StringBuilder();

                //Run the thing.
                process.StartInfo.FileName = "ffmpeg.exe";
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.RedirectStandardError = true;
                process.StartInfo.CreateNoWindow = true;
                process.StartInfo.Arguments = runArgs;

                //Event to handle async whatever
                process.ErrorDataReceived += new DataReceivedEventHandler((sending, ev) =>
                {
                    // Prepend line numbers to each line of the output. 
                    if (!String.IsNullOrEmpty(ev.Data))
                    {
                        lineCount++;
                        output.Append("\n[" + lineCount + "]: " + ev.Data);
                        Console.WriteLine(ev.Data);
                        if (ev.Data.Contains("frame=")) { updateStatus(ev.Data); }
                    }
                });

                process.Start();
                Console.WriteLine(runArgs);

                // Synchronously read the standard output of the spawned process. 
                process.BeginErrorReadLine();
            }
        }

        //Special invoke threadsafe trickery
        private void updateStatus(string text)
        {
            //Make sure our control still exists. User may have close window.
            if (!this.statusBar.IsDisposed)
            {
                //Check to see if we are from another thread.
                if (this.statusBar.InvokeRequired)
                {
                    //Do invoke/callback.
                    updateTextCallback d = new updateTextCallback(updateStatus);
                    this.Invoke(d, new object[] { text });
                }
                else { statusBar.Text = text; }
            }
        }

        private void buttonPause_Click(object sender, EventArgs e)
        {
            if (isRunning())
            {
                if (!paused)
                {
                    SuspendProcess(process.Id);
                    paused = true;
                    buttonPause.Text = "Resume";
                }
                else
                {
                    ResumeProcess(process.Id);
                    paused = false;
                    buttonPause.Text = "Pause";
                }
            }
        }

        private static void SuspendProcess(int pid)
        {
            var process = Process.GetProcessById(pid);

            if (process.ProcessName == string.Empty)
                return;

            foreach (ProcessThread pT in process.Threads)
            {
                IntPtr pOpenThread = OpenThread(ThreadAccess.SUSPEND_RESUME, false, (uint)pT.Id);

                if (pOpenThread == IntPtr.Zero)
                {
                    continue;
                }

                SuspendThread(pOpenThread);

                //CloseHandle(pOpenThread);
            }
        }

        public static void ResumeProcess(int pid)
        {
            var process = Process.GetProcessById(pid);

            if (process.ProcessName == string.Empty)
                return;

            foreach (ProcessThread pT in process.Threads)
            {
                IntPtr pOpenThread = OpenThread(ThreadAccess.SUSPEND_RESUME, false, (uint)pT.Id);

                if (pOpenThread == IntPtr.Zero)
                {
                    continue;
                }

                var suspendCount = 0;
                do
                {
                    suspendCount = ResumeThread(pOpenThread);
                } while (suspendCount > 0);

                //CloseHandle(pOpenThread);
            }
        }

        private void buttonResume_Click(object sender, EventArgs e)
        {
            ResumeProcess(process.Id);
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Stop the instance of ffmpeg
            if (isRunning())
            {
                process.Kill();
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            try { fileName = Environment.GetCommandLineArgs()[1]; }
            catch (Exception error) { }
            destination.Text = targetURL;
            file.Text = fileName;
            bitrateAudio.Value = aBit;
            bitrateVideo.Value = vBit;
            videoRes.Text = vSize;
            buttonPause.Enabled = false;
        }

        private void file_TextChanged(object sender, EventArgs e)
        {
            fileName = file.Text;
        }

        private void destination_TextChanged(object sender, EventArgs e)
        {
            targetURL = destination.Text;
        }

        private bool isRunning()
        {
            //Basic sanity check. TODO Find a better way to do this.
            bool running = false;
            if (process.StartInfo.FileName != "")
            {
                //if (process.Responding) { running = true; }
                if (!process.HasExited) { running = true; }
            }
            return running;
        }

        private void bitrateVideo_ValueChanged(object sender, EventArgs e)
        {
            vBit = (int)bitrateVideo.Value;
        }

        private void bitrateAudio_ValueChanged(object sender, EventArgs e)
        {
            aBit = (int)bitrateAudio.Value;
        }

        private void videoRes_TextChanged(object sender, EventArgs e)
        {
            vSize = videoRes.Text;
        }

        private void numHour_ValueChanged(object sender, EventArgs e)
        {
            startTime[0] = (int)numHour.Value;
        }

        private void numMin_ValueChanged(object sender, EventArgs e)
        {
            startTime[1] = (int)numMin.Value;
        }

        private void numSec_ValueChanged(object sender, EventArgs e)
        {
            startTime[2] = (int)numSec.Value;
        }
    }
}