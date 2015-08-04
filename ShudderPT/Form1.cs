using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShudderPT
{
    public partial class Main : Form
    {
        //Our ffmpeg process
        Process process = new Process();

        //Other stuff for file checking
        Stopwatch time = new Stopwatch();
        Timer globalTime = new Timer();
        TimeSpan lastTime = new TimeSpan();

        //FFMpeg flags
        string targetURL = "rtmp://stream.reblink.org/live/Reblink";
        string fileName = "";
        string subName = "";
        int[] startTime = { 0, 0, 0 };
        int vBit = 1500;
        int aBit = 196;
        int vRate = 30;
        int aRate = 44100;
        int crfNum = 18;
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

        //Threadsafe callback delegates
        delegate void updateTextCallback(string text);
        delegate void updateTitleCallback();

        //Init form
        public Main()
        {
            InitializeComponent();
        }

        private void buttonStream_Click(object sender, EventArgs e)
        {
            if (!isRunning())
            {
                StartStream();
                buttonPause.Enabled = true;
                buttonStream.Text = "Stop";
            }
            else
            {
                StopStream();
                buttonPause.Enabled = false;
                buttonStream.Text = "Stream";
            }
        }

        public void StartStream()
        {
            if (!isRunning())
            {
                //Subs or no subs?
                string sub = "";
                if (subCheck.Checked) { sub = "-vf subtitles=" + subName; }

                //Our args for ffmpeg.
                string[] runArgs = { "-re -y "
                    , "-ss " + string.Join(":", startTime)//Start time
                    , "-i \"" + fileName + "\""           //File name
                    , "-vcodec " + vCodec                 //Video codec
                    , "-b:v " + vBit + "k"                //Video bitrate
                    , "-r " + vRate                       //Video framerate
                    , "-bufsize " + vBit*2 +"k"           //Buffer size
                    , "-g " + vRate*2                     //GOP size
                    , "-s " + vSize                       //Video resolution
                    , "-filter:v yadif "                  //Video filters
                    //, "-crf " + crfNum                  //CRF value
                    , "-acodec " + aCodec                 //Audio codec
                    , "-ab " + aBit + "k"                 //Audio bitrate
                    , "-ac 2"                             //Audio channels
                    , "-ar " + aRate                      //Audio sample rate
                    , sub                                 //Subtitles
                    , "-f flv \"" + targetURL + "\"" };   //Target url

                //Run the thing.
                process.StartInfo.FileName = "ffmpeg.exe";
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.RedirectStandardError = true;
                process.StartInfo.CreateNoWindow = true;
                process.StartInfo.Arguments = string.Join(" ",runArgs);

                //Event to handle async whatever
                process.ErrorDataReceived += new DataReceivedEventHandler((sending, ev) =>
                {
                    if (!String.IsNullOrEmpty(ev.Data))
                    {
                        Console.WriteLine(@ev.Data);
                        if (ev.Data.Contains("frame="))
                        {
                            updateStatus(ev.Data);
                            updateTitle();
                        }
                    }
                });

                process.Start();
                Console.WriteLine(string.Join(" ",runArgs));

                // Synchronously read the standard output of the spawned process.
                try {
                    process.BeginErrorReadLine();
                    lastTime = time.Elapsed;
                    time.Start();
                }
                catch (Exception error) { }
            }
        }

        public void StopStream()
        {
            //Stop the instance of ffmpeg
            if (isRunning())
            {
                process.Kill();
                time.Stop();
            }
        }

        //Special invoke threadsafe trickery
        private void updateStatus(string text)
        {
            //Make sure our controls still exists. User may have closed window.
            if (!this.IsDisposed)
            {
                //Check to see if we are from another thread.
                if (this.statusStrip.InvokeRequired)
                {
                    //Do invoke/callback.
                    updateTextCallback d = new updateTextCallback(updateStatus);
                    this.Invoke(d, new object[] { text });
                }
                else { statusBar.Text = text; }
            }
        }

        private void updateTitle()
        {
            //Again. Make sure we still exist.
            if (!this.IsDisposed)
            {
                //YO WE SAFE?
                if (this.timeDiff.InvokeRequired)
                {
                    //SHIT NO WE AINT.
                    updateTitleCallback d = new updateTitleCallback(updateTitle);
                    this.Invoke(d);
                }
                else
                {
                    double update = (time.Elapsed - lastTime).TotalMilliseconds;
                    this.timeDiff.Text = update.ToString();
                    //Color the bar depending on the time it took to transcode the last frame.
                    if (update < 600)
                    {
                        timeDiff.BackColor = Color.Green;
                    }
                    if (update >= 600 && update < 1000)
                    {
                        timeDiff.BackColor = Color.Yellow;
                    }
                    if (update >= 1000)
                    {
                        timeDiff.BackColor = Color.Red;
                    }
                    lastTime = time.Elapsed;
                }
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
            StopStream();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            try { fileName = Environment.GetCommandLineArgs()[1]; }
            catch (Exception error) { }
            if( fileName != "")
            {
                //Look for matching .srt for our file.
                string[] paths = Directory.GetFiles(Path.GetDirectoryName(Path.GetFullPath(fileName)));
                getFileData(fileName);
                string sub = Path.GetDirectoryName(Path.GetFullPath(fileName)) +"\\"+Path.GetFileNameWithoutExtension(fileName) + ".srt";
                if (paths.Contains(sub))
                {
                    //Update our sub name. THE ESCAPE IS REAL.
                    subName = "\"" + sub.Replace("\\","\\\\\\\\").Replace(":", "\\\\:") + "\"" + ":force_style='FontName=Arial,FontSize=20'";
                    subCheck.Enabled = true;
                    //updateStatus(subName);
                }
            }
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
            //Did we even get there?
            if (process.StartInfo.FileName != "")
            {
                //So sain. UUUUNF.
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

        private void globalTimer_Tick(object sender, EventArgs e)
        {
            //this.Text = time.Elapsed.ToString();
        }

        public string[] getFileData(string path)
        {
            Process ffmpeg = new Process();
            //Run the thing.
            ffmpeg.StartInfo.FileName = "ffmpeg.exe";
            ffmpeg.StartInfo.UseShellExecute = false;
            ffmpeg.StartInfo.RedirectStandardOutput = true;
            ffmpeg.StartInfo.RedirectStandardError = true;
            ffmpeg.StartInfo.CreateNoWindow = true;
            ffmpeg.StartInfo.Arguments = "-i " + "\"" + Path.GetFullPath(path) + "\"";

            List<string> output = new List<string>();

            ffmpeg.Start();

            using (StreamReader reader = ffmpeg.StandardError)
            {
                string result = reader.ReadToEnd();
                result = result.Substring(result.IndexOf("Duration: "));
                //Split the output.
                string[] splits = result.Split(new string[] { Environment.NewLine },StringSplitOptions.None);



                //Put the info in the box. WHY NOT?
                infoList.Text = result;

                Console.WriteLine(result);

                output.Add(result);
            }

            return output.ToArray();
        }
    }
}
