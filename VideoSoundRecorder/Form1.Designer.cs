namespace VideoSoundRecorder
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panelWindow = new System.Windows.Forms.Panel();
            this.StartStopBtn = new System.Windows.Forms.Button();
            this.StopBtn = new System.Windows.Forms.Button();
            this.StartBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button_Start = new System.Windows.Forms.Button();
            this.comboBox_AudioDevices = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_VideoDevices = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox_VideoCapture = new System.Windows.Forms.PictureBox();
            this.panelWindow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_VideoCapture)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(914, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 754);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(914, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panelWindow
            // 
            this.panelWindow.BackColor = System.Drawing.Color.MistyRose;
            this.panelWindow.Controls.Add(this.StartStopBtn);
            this.panelWindow.Controls.Add(this.StopBtn);
            this.panelWindow.Controls.Add(this.StartBtn);
            this.panelWindow.Controls.Add(this.button1);
            this.panelWindow.Controls.Add(this.button_Start);
            this.panelWindow.Controls.Add(this.comboBox_AudioDevices);
            this.panelWindow.Controls.Add(this.label2);
            this.panelWindow.Controls.Add(this.comboBox_VideoDevices);
            this.panelWindow.Controls.Add(this.label1);
            this.panelWindow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelWindow.Location = new System.Drawing.Point(0, 24);
            this.panelWindow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelWindow.Name = "panelWindow";
            this.panelWindow.Size = new System.Drawing.Size(914, 319);
            this.panelWindow.TabIndex = 2;
            // 
            // StartStopBtn
            // 
            this.StartStopBtn.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StartStopBtn.Location = new System.Drawing.Point(291, 241);
            this.StartStopBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StartStopBtn.Name = "StartStopBtn";
            this.StartStopBtn.Size = new System.Drawing.Size(332, 48);
            this.StartStopBtn.TabIndex = 5;
            this.StartStopBtn.Text = "Start Audio";
            this.StartStopBtn.UseVisualStyleBackColor = true;
            this.StartStopBtn.Click += new System.EventHandler(this.StartStopBtn_Click);
            // 
            // StopBtn
            // 
            this.StopBtn.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StopBtn.Location = new System.Drawing.Point(460, 151);
            this.StopBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StopBtn.Name = "StopBtn";
            this.StopBtn.Size = new System.Drawing.Size(163, 48);
            this.StopBtn.TabIndex = 4;
            this.StopBtn.Text = "Stop audio";
            this.StopBtn.UseVisualStyleBackColor = true;
            this.StopBtn.Click += new System.EventHandler(this.StopBtn_Click);
            // 
            // StartBtn
            // 
            this.StartBtn.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StartBtn.Location = new System.Drawing.Point(291, 151);
            this.StartBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(163, 48);
            this.StartBtn.TabIndex = 3;
            this.StartBtn.Text = "Start Audio";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(462, 47);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 48);
            this.button1.TabIndex = 2;
            this.button1.Text = "Start Sound";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_Start
            // 
            this.button_Start.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Start.Location = new System.Drawing.Point(291, 47);
            this.button_Start.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(163, 48);
            this.button_Start.TabIndex = 2;
            this.button_Start.Text = "Start Video";
            this.button_Start.UseVisualStyleBackColor = true;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // comboBox_AudioDevices
            // 
            this.comboBox_AudioDevices.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox_AudioDevices.FormattingEnabled = true;
            this.comboBox_AudioDevices.Location = new System.Drawing.Point(632, 47);
            this.comboBox_AudioDevices.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox_AudioDevices.Name = "comboBox_AudioDevices";
            this.comboBox_AudioDevices.Size = new System.Drawing.Size(268, 43);
            this.comboBox_AudioDevices.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(632, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 35);
            this.label2.TabIndex = 0;
            this.label2.Text = "Audio Devices";
            // 
            // comboBox_VideoDevices
            // 
            this.comboBox_VideoDevices.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox_VideoDevices.FormattingEnabled = true;
            this.comboBox_VideoDevices.Location = new System.Drawing.Point(15, 47);
            this.comboBox_VideoDevices.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox_VideoDevices.Name = "comboBox_VideoDevices";
            this.comboBox_VideoDevices.Size = new System.Drawing.Size(268, 43);
            this.comboBox_VideoDevices.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(15, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Video Devices";
            // 
            // pictureBox_VideoCapture
            // 
            this.pictureBox_VideoCapture.Location = new System.Drawing.Point(15, 351);
            this.pictureBox_VideoCapture.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox_VideoCapture.Name = "pictureBox_VideoCapture";
            this.pictureBox_VideoCapture.Size = new System.Drawing.Size(886, 392);
            this.pictureBox_VideoCapture.TabIndex = 3;
            this.pictureBox_VideoCapture.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 776);
            this.Controls.Add(this.pictureBox_VideoCapture);
            this.Controls.Add(this.panelWindow);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelWindow.ResumeLayout(false);
            this.panelWindow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_VideoCapture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panelWindow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_VideoDevices;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.ComboBox comboBox_AudioDevices;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox_VideoCapture;
        private System.Windows.Forms.Button StopBtn;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Button StartStopBtn;
    }
}

