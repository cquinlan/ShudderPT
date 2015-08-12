namespace ShudderPT
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.buttonStream = new System.Windows.Forms.Button();
            this.buttonPause = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusBar = new System.Windows.Forms.ToolStripStatusLabel();
            this.bitrateAudioSlide = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.fileRuntime = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numSec = new System.Windows.Forms.NumericUpDown();
            this.numMin = new System.Windows.Forms.NumericUpDown();
            this.numHour = new System.Windows.Forms.NumericUpDown();
            this.subCheck = new System.Windows.Forms.CheckBox();
            this.destination = new System.Windows.Forms.TextBox();
            this.file = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.videoGetSource = new System.Windows.Forms.Button();
            this.bitrateVideoSlide = new System.Windows.Forms.TrackBar();
            this.videoRes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bitrateVideo = new System.Windows.Forms.NumericUpDown();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.audioGetSource = new System.Windows.Forms.Button();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.bitrateAudio = new System.Windows.Forms.NumericUpDown();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.timeDiff = new System.Windows.Forms.TextBox();
            this.infoBox = new System.Windows.Forms.RichTextBox();
            this.statusStrip.SuspendLayout();
            this.bitrateAudioSlide.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHour)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bitrateVideoSlide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bitrateVideo)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bitrateAudio)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonStream
            // 
            resources.ApplyResources(this.buttonStream, "buttonStream");
            this.buttonStream.Name = "buttonStream";
            this.buttonStream.UseVisualStyleBackColor = true;
            this.buttonStream.Click += new System.EventHandler(this.buttonStream_Click);
            // 
            // buttonPause
            // 
            resources.ApplyResources(this.buttonPause, "buttonPause");
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.UseVisualStyleBackColor = true;
            this.buttonPause.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBar});
            resources.ApplyResources(this.statusStrip, "statusStrip");
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.SizingGrip = false;
            // 
            // statusBar
            // 
            this.statusBar.Name = "statusBar";
            resources.ApplyResources(this.statusBar, "statusBar");
            // 
            // bitrateAudioSlide
            // 
            this.bitrateAudioSlide.Controls.Add(this.tabPage1);
            this.bitrateAudioSlide.Controls.Add(this.tabPage2);
            this.bitrateAudioSlide.Controls.Add(this.tabPage3);
            this.bitrateAudioSlide.Controls.Add(this.tabPage4);
            resources.ApplyResources(this.bitrateAudioSlide, "bitrateAudioSlide");
            this.bitrateAudioSlide.Name = "bitrateAudioSlide";
            this.bitrateAudioSlide.SelectedIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.fileRuntime);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.numSec);
            this.tabPage1.Controls.Add(this.numMin);
            this.tabPage1.Controls.Add(this.numHour);
            this.tabPage1.Controls.Add(this.subCheck);
            this.tabPage1.Controls.Add(this.destination);
            this.tabPage1.Controls.Add(this.file);
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // fileRuntime
            // 
            resources.ApplyResources(this.fileRuntime, "fileRuntime");
            this.fileRuntime.Name = "fileRuntime";
            this.fileRuntime.ReadOnly = true;
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // numSec
            // 
            resources.ApplyResources(this.numSec, "numSec");
            this.numSec.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numSec.Name = "numSec";
            this.numSec.ValueChanged += new System.EventHandler(this.numSec_ValueChanged);
            // 
            // numMin
            // 
            resources.ApplyResources(this.numMin, "numMin");
            this.numMin.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numMin.Name = "numMin";
            this.numMin.ValueChanged += new System.EventHandler(this.numMin_ValueChanged);
            // 
            // numHour
            // 
            resources.ApplyResources(this.numHour, "numHour");
            this.numHour.Name = "numHour";
            this.numHour.ValueChanged += new System.EventHandler(this.numHour_ValueChanged);
            // 
            // subCheck
            // 
            resources.ApplyResources(this.subCheck, "subCheck");
            this.subCheck.Name = "subCheck";
            this.subCheck.UseVisualStyleBackColor = true;
            // 
            // destination
            // 
            resources.ApplyResources(this.destination, "destination");
            this.destination.Name = "destination";
            this.destination.TextChanged += new System.EventHandler(this.destination_TextChanged);
            // 
            // file
            // 
            resources.ApplyResources(this.file, "file");
            this.file.Name = "file";
            this.file.TextChanged += new System.EventHandler(this.file_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.videoGetSource);
            this.tabPage2.Controls.Add(this.bitrateVideoSlide);
            this.tabPage2.Controls.Add(this.videoRes);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.bitrateVideo);
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // videoGetSource
            // 
            resources.ApplyResources(this.videoGetSource, "videoGetSource");
            this.videoGetSource.Name = "videoGetSource";
            this.videoGetSource.UseVisualStyleBackColor = true;
            this.videoGetSource.Click += new System.EventHandler(this.videoGetSource_Click);
            // 
            // bitrateVideoSlide
            // 
            resources.ApplyResources(this.bitrateVideoSlide, "bitrateVideoSlide");
            this.bitrateVideoSlide.LargeChange = 50;
            this.bitrateVideoSlide.Maximum = 100;
            this.bitrateVideoSlide.Minimum = 50;
            this.bitrateVideoSlide.Name = "bitrateVideoSlide";
            this.bitrateVideoSlide.SmallChange = 10;
            this.bitrateVideoSlide.Value = 50;
            this.bitrateVideoSlide.Scroll += new System.EventHandler(this.bitrateVideoSlide_Scroll);
            // 
            // videoRes
            // 
            resources.ApplyResources(this.videoRes, "videoRes");
            this.videoRes.Name = "videoRes";
            this.videoRes.TextChanged += new System.EventHandler(this.videoRes_TextChanged);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // bitrateVideo
            // 
            resources.ApplyResources(this.bitrateVideo, "bitrateVideo");
            this.bitrateVideo.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.bitrateVideo.Name = "bitrateVideo";
            this.bitrateVideo.ValueChanged += new System.EventHandler(this.bitrateVideo_ValueChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.audioGetSource);
            this.tabPage3.Controls.Add(this.trackBar2);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.bitrateAudio);
            resources.ApplyResources(this.tabPage3, "tabPage3");
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // audioGetSource
            // 
            resources.ApplyResources(this.audioGetSource, "audioGetSource");
            this.audioGetSource.Name = "audioGetSource";
            this.audioGetSource.UseVisualStyleBackColor = true;
            this.audioGetSource.Click += new System.EventHandler(this.audioGetSource_Click);
            // 
            // trackBar2
            // 
            resources.ApplyResources(this.trackBar2, "trackBar2");
            this.trackBar2.Name = "trackBar2";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // bitrateAudio
            // 
            resources.ApplyResources(this.bitrateAudio, "bitrateAudio");
            this.bitrateAudio.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.bitrateAudio.Name = "bitrateAudio";
            this.bitrateAudio.ValueChanged += new System.EventHandler(this.bitrateAudio_ValueChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.infoBox);
            resources.ApplyResources(this.tabPage4, "tabPage4");
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // timeDiff
            // 
            resources.ApplyResources(this.timeDiff, "timeDiff");
            this.timeDiff.Name = "timeDiff";
            this.timeDiff.ReadOnly = true;
            // 
            // infoBox
            // 
            resources.ApplyResources(this.infoBox, "infoBox");
            this.infoBox.Name = "infoBox";
            // 
            // Main
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.timeDiff);
            this.Controls.Add(this.bitrateAudioSlide);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.buttonPause);
            this.Controls.Add(this.buttonStream);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Main";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.bitrateAudioSlide.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHour)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bitrateVideoSlide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bitrateVideo)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bitrateAudio)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStream;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusBar;
        private System.Windows.Forms.TabControl bitrateAudioSlide;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numSec;
        private System.Windows.Forms.NumericUpDown numMin;
        private System.Windows.Forms.NumericUpDown numHour;
        private System.Windows.Forms.CheckBox subCheck;
        private System.Windows.Forms.TextBox destination;
        private System.Windows.Forms.TextBox file;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TrackBar bitrateVideoSlide;
        private System.Windows.Forms.TextBox videoRes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown bitrateVideo;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown bitrateAudio;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox timeDiff;
        private System.Windows.Forms.Button videoGetSource;
        private System.Windows.Forms.Button audioGetSource;
        private System.Windows.Forms.TextBox fileRuntime;
        private System.Windows.Forms.RichTextBox infoBox;
    }
}

