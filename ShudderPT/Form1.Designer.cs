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
            this.file = new System.Windows.Forms.TextBox();
            this.destination = new System.Windows.Forms.TextBox();
            this.bitrateVideo = new System.Windows.Forms.NumericUpDown();
            this.bitrateAudio = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonPause = new System.Windows.Forms.Button();
            this.numHour = new System.Windows.Forms.NumericUpDown();
            this.numMin = new System.Windows.Forms.NumericUpDown();
            this.numSec = new System.Windows.Forms.NumericUpDown();
            this.videoRes = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusBar = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.bitrateVideo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bitrateAudio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSec)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonStream
            // 
            this.buttonStream.Location = new System.Drawing.Point(421, 12);
            this.buttonStream.Name = "buttonStream";
            this.buttonStream.Size = new System.Drawing.Size(75, 46);
            this.buttonStream.TabIndex = 0;
            this.buttonStream.Text = "Stream";
            this.buttonStream.UseVisualStyleBackColor = true;
            this.buttonStream.Click += new System.EventHandler(this.buttonStream_Click);
            // 
            // file
            // 
            this.file.Location = new System.Drawing.Point(12, 12);
            this.file.Name = "file";
            this.file.Size = new System.Drawing.Size(403, 20);
            this.file.TabIndex = 1;
            this.file.TextChanged += new System.EventHandler(this.file_TextChanged);
            // 
            // destination
            // 
            this.destination.Location = new System.Drawing.Point(12, 38);
            this.destination.Name = "destination";
            this.destination.Size = new System.Drawing.Size(403, 20);
            this.destination.TabIndex = 2;
            this.destination.TextChanged += new System.EventHandler(this.destination_TextChanged);
            // 
            // bitrateVideo
            // 
            this.bitrateVideo.Location = new System.Drawing.Point(12, 80);
            this.bitrateVideo.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.bitrateVideo.Name = "bitrateVideo";
            this.bitrateVideo.Size = new System.Drawing.Size(67, 20);
            this.bitrateVideo.TabIndex = 3;
            this.bitrateVideo.ValueChanged += new System.EventHandler(this.bitrateVideo_ValueChanged);
            // 
            // bitrateAudio
            // 
            this.bitrateAudio.Location = new System.Drawing.Point(85, 80);
            this.bitrateAudio.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.bitrateAudio.Name = "bitrateAudio";
            this.bitrateAudio.Size = new System.Drawing.Size(67, 20);
            this.bitrateAudio.TabIndex = 4;
            this.bitrateAudio.ValueChanged += new System.EventHandler(this.bitrateAudio_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Video Bitrate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Audio Bitrate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(155, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Video Resolution";
            // 
            // buttonPause
            // 
            this.buttonPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPause.Location = new System.Drawing.Point(421, 64);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(74, 36);
            this.buttonPause.TabIndex = 9;
            this.buttonPause.Text = "Pause";
            this.buttonPause.UseVisualStyleBackColor = true;
            this.buttonPause.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // numHour
            // 
            this.numHour.Location = new System.Drawing.Point(251, 80);
            this.numHour.Name = "numHour";
            this.numHour.Size = new System.Drawing.Size(40, 20);
            this.numHour.TabIndex = 11;
            this.numHour.ValueChanged += new System.EventHandler(this.numHour_ValueChanged);
            // 
            // numMin
            // 
            this.numMin.Location = new System.Drawing.Point(313, 80);
            this.numMin.Name = "numMin";
            this.numMin.Size = new System.Drawing.Size(40, 20);
            this.numMin.TabIndex = 12;
            this.numMin.ValueChanged += new System.EventHandler(this.numMin_ValueChanged);
            // 
            // numSec
            // 
            this.numSec.Location = new System.Drawing.Point(375, 80);
            this.numSec.Name = "numSec";
            this.numSec.Size = new System.Drawing.Size(40, 20);
            this.numSec.TabIndex = 13;
            this.numSec.ValueChanged += new System.EventHandler(this.numSec_ValueChanged);
            // 
            // videoRes
            // 
            this.videoRes.Location = new System.Drawing.Point(158, 80);
            this.videoRes.Name = "videoRes";
            this.videoRes.Size = new System.Drawing.Size(84, 20);
            this.videoRes.TabIndex = 10;
            this.videoRes.TextChanged += new System.EventHandler(this.videoRes_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(297, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(359, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = ":";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(248, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Start Time";
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBar});
            this.statusStrip.Location = new System.Drawing.Point(0, 109);
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
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 131);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numSec);
            this.Controls.Add(this.numMin);
            this.Controls.Add(this.numHour);
            this.Controls.Add(this.videoRes);
            this.Controls.Add(this.buttonPause);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bitrateAudio);
            this.Controls.Add(this.bitrateVideo);
            this.Controls.Add(this.destination);
            this.Controls.Add(this.file);
            this.Controls.Add(this.buttonStream);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Main";
            this.Text = "Shudder PT";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bitrateVideo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bitrateAudio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSec)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStream;
        private System.Windows.Forms.TextBox file;
        private System.Windows.Forms.TextBox destination;
        private System.Windows.Forms.NumericUpDown bitrateVideo;
        private System.Windows.Forms.NumericUpDown bitrateAudio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.NumericUpDown numHour;
        private System.Windows.Forms.NumericUpDown numMin;
        private System.Windows.Forms.NumericUpDown numSec;
        private System.Windows.Forms.TextBox videoRes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusBar;
    }
}

