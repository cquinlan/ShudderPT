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
            this.buttonStream = new System.Windows.Forms.Button();
            this.buttonPause = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusBar = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
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
            this.trackBar1 = new System.Windows.Forms.TrackBar();
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
            this.infoList = new System.Windows.Forms.RichTextBox();
            this.timeDiff = new System.Windows.Forms.TextBox();
            this.fileRuntime = new System.Windows.Forms.TextBox();
            this.statusStrip.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHour)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bitrateVideo)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bitrateAudio)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonStream
            // 
            this.buttonStream.Location = new System.Drawing.Point(421, 34);
            this.buttonStream.Name = "buttonStream";
            this.buttonStream.Size = new System.Drawing.Size(75, 52);
            this.buttonStream.TabIndex = 0;
            this.buttonStream.Text = "Stream";
            this.buttonStream.UseVisualStyleBackColor = true;
            this.buttonStream.Click += new System.EventHandler(this.buttonStream_Click);
            // 
            // buttonPause
            // 
            this.buttonPause.Location = new System.Drawing.Point(422, 92);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(74, 24);
            this.buttonPause.TabIndex = 9;
            this.buttonPause.Text = "Pause";
            this.buttonPause.UseVisualStyleBackColor = true;
            this.buttonPause.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBar});
            this.statusStrip.Location = new System.Drawing.Point(0, 150);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(508, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 18;
            this.statusStrip.Text = "statusStrip";
            // 
            // statusBar
            // 
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(26, 17);
            this.statusBar.Text = "Idle";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(403, 131);
            this.tabControl1.TabIndex = 20;
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
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(395, 105);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Stream";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Start Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(114, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = ":";
            // 
            // numSec
            // 
            this.numSec.Location = new System.Drawing.Point(130, 74);
            this.numSec.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numSec.Name = "numSec";
            this.numSec.Size = new System.Drawing.Size(40, 20);
            this.numSec.TabIndex = 31;
            // 
            // numMin
            // 
            this.numMin.Location = new System.Drawing.Point(68, 74);
            this.numMin.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numMin.Name = "numMin";
            this.numMin.Size = new System.Drawing.Size(40, 20);
            this.numMin.TabIndex = 30;
            // 
            // numHour
            // 
            this.numHour.Location = new System.Drawing.Point(6, 74);
            this.numHour.Name = "numHour";
            this.numHour.Size = new System.Drawing.Size(40, 20);
            this.numHour.TabIndex = 29;
            // 
            // subCheck
            // 
            this.subCheck.AutoSize = true;
            this.subCheck.Enabled = false;
            this.subCheck.Location = new System.Drawing.Point(323, 35);
            this.subCheck.Name = "subCheck";
            this.subCheck.Size = new System.Drawing.Size(66, 17);
            this.subCheck.TabIndex = 22;
            this.subCheck.Text = "Subtitles";
            this.subCheck.UseVisualStyleBackColor = true;
            // 
            // destination
            // 
            this.destination.Location = new System.Drawing.Point(6, 6);
            this.destination.Name = "destination";
            this.destination.Size = new System.Drawing.Size(383, 20);
            this.destination.TabIndex = 21;
            // 
            // file
            // 
            this.file.Location = new System.Drawing.Point(6, 32);
            this.file.Name = "file";
            this.file.Size = new System.Drawing.Size(211, 20);
            this.file.TabIndex = 20;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.videoGetSource);
            this.tabPage2.Controls.Add(this.trackBar1);
            this.tabPage2.Controls.Add(this.videoRes);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.bitrateVideo);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(395, 105);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Video";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // videoGetSource
            // 
            this.videoGetSource.Location = new System.Drawing.Point(314, 17);
            this.videoGetSource.Name = "videoGetSource";
            this.videoGetSource.Size = new System.Drawing.Size(75, 23);
            this.videoGetSource.TabIndex = 24;
            this.videoGetSource.Text = "Source";
            this.videoGetSource.UseVisualStyleBackColor = true;
            // 
            // trackBar1
            // 
            this.trackBar1.Enabled = false;
            this.trackBar1.Location = new System.Drawing.Point(6, 54);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(383, 45);
            this.trackBar1.TabIndex = 23;
            // 
            // videoRes
            // 
            this.videoRes.Location = new System.Drawing.Point(79, 19);
            this.videoRes.Name = "videoRes";
            this.videoRes.Size = new System.Drawing.Size(84, 20);
            this.videoRes.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Video Resolution";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Video Bitrate";
            // 
            // bitrateVideo
            // 
            this.bitrateVideo.Location = new System.Drawing.Point(6, 19);
            this.bitrateVideo.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.bitrateVideo.Name = "bitrateVideo";
            this.bitrateVideo.Size = new System.Drawing.Size(67, 20);
            this.bitrateVideo.TabIndex = 17;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.audioGetSource);
            this.tabPage3.Controls.Add(this.trackBar2);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.bitrateAudio);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(395, 105);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Audio";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // audioGetSource
            // 
            this.audioGetSource.Location = new System.Drawing.Point(314, 17);
            this.audioGetSource.Name = "audioGetSource";
            this.audioGetSource.Size = new System.Drawing.Size(75, 23);
            this.audioGetSource.TabIndex = 25;
            this.audioGetSource.Text = "Source";
            this.audioGetSource.UseVisualStyleBackColor = true;
            // 
            // trackBar2
            // 
            this.trackBar2.Enabled = false;
            this.trackBar2.Location = new System.Drawing.Point(6, 54);
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(383, 45);
            this.trackBar2.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Audio Bitrate";
            // 
            // bitrateAudio
            // 
            this.bitrateAudio.Location = new System.Drawing.Point(6, 19);
            this.bitrateAudio.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.bitrateAudio.Name = "bitrateAudio";
            this.bitrateAudio.Size = new System.Drawing.Size(67, 20);
            this.bitrateAudio.TabIndex = 21;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.infoList);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(395, 105);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Info";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // infoList
            // 
            this.infoList.Location = new System.Drawing.Point(7, 7);
            this.infoList.Name = "infoList";
            this.infoList.Size = new System.Drawing.Size(382, 92);
            this.infoList.TabIndex = 0;
            this.infoList.Text = "";
            // 
            // timeDiff
            // 
            this.timeDiff.Location = new System.Drawing.Point(422, 122);
            this.timeDiff.Name = "timeDiff";
            this.timeDiff.ReadOnly = true;
            this.timeDiff.Size = new System.Drawing.Size(74, 20);
            this.timeDiff.TabIndex = 21;
            // 
            // fileRuntime
            // 
            this.fileRuntime.Location = new System.Drawing.Point(223, 32);
            this.fileRuntime.Name = "fileRuntime";
            this.fileRuntime.ReadOnly = true;
            this.fileRuntime.Size = new System.Drawing.Size(94, 20);
            this.fileRuntime.TabIndex = 35;
            this.fileRuntime.Text = "00:00:00.00";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 172);
            this.Controls.Add(this.timeDiff);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.buttonPause);
            this.Controls.Add(this.buttonStream);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Main";
            this.Text = "Shudder PT";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHour)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
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
        private System.Windows.Forms.TabControl tabControl1;
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
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TextBox videoRes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown bitrateVideo;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown bitrateAudio;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.RichTextBox infoList;
        private System.Windows.Forms.TextBox timeDiff;
        private System.Windows.Forms.Button videoGetSource;
        private System.Windows.Forms.Button audioGetSource;
        private System.Windows.Forms.TextBox fileRuntime;
    }
}

