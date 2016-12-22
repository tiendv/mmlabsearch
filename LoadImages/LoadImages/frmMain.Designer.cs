namespace LoadImages
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tabControlVideoFrames = new System.Windows.Forms.TabControl();
            this.tabVideoFrames = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControlShotFrames = new System.Windows.Forms.TabControl();
            this.tabShotFrames = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.tabControlVideoFrames.SuspendLayout();
            this.tabControlShotFrames.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlVideoFrames
            // 
            this.tabControlVideoFrames.Controls.Add(this.tabVideoFrames);
            this.tabControlVideoFrames.Controls.Add(this.tabPage2);
            this.tabControlVideoFrames.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabControlVideoFrames.Location = new System.Drawing.Point(0, 0);
            this.tabControlVideoFrames.Name = "tabControlVideoFrames";
            this.tabControlVideoFrames.SelectedIndex = 0;
            this.tabControlVideoFrames.Size = new System.Drawing.Size(295, 438);
            this.tabControlVideoFrames.TabIndex = 3;
            // 
            // tabVideoFrames
            // 
            this.tabVideoFrames.AutoScroll = true;
            this.tabVideoFrames.Location = new System.Drawing.Point(4, 25);
            this.tabVideoFrames.Name = "tabVideoFrames";
            this.tabVideoFrames.Padding = new System.Windows.Forms.Padding(3);
            this.tabVideoFrames.Size = new System.Drawing.Size(287, 409);
            this.tabVideoFrames.TabIndex = 0;
            this.tabVideoFrames.Text = "Video Frames";
            this.tabVideoFrames.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(287, 409);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Others ...";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabControlShotFrames
            // 
            this.tabControlShotFrames.Controls.Add(this.tabShotFrames);
            this.tabControlShotFrames.Controls.Add(this.tabPage4);
            this.tabControlShotFrames.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabControlShotFrames.Location = new System.Drawing.Point(295, 0);
            this.tabControlShotFrames.Name = "tabControlShotFrames";
            this.tabControlShotFrames.SelectedIndex = 0;
            this.tabControlShotFrames.Size = new System.Drawing.Size(295, 438);
            this.tabControlShotFrames.TabIndex = 4;
            // 
            // tabShotFrames
            // 
            this.tabShotFrames.AutoScroll = true;
            this.tabShotFrames.Location = new System.Drawing.Point(4, 25);
            this.tabShotFrames.Name = "tabShotFrames";
            this.tabShotFrames.Padding = new System.Windows.Forms.Padding(3);
            this.tabShotFrames.Size = new System.Drawing.Size(287, 409);
            this.tabShotFrames.TabIndex = 0;
            this.tabShotFrames.Text = "Shot Frames";
            this.tabShotFrames.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(287, 409);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Others ...";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.axWindowsMediaPlayer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(590, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(412, 438);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(412, 125);
            this.panel2.TabIndex = 1;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 125);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(412, 313);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1002, 438);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControlShotFrames);
            this.Controls.Add(this.tabControlVideoFrames);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.SizeChanged += new System.EventHandler(this.frmMain_SizeChanged);
            this.tabControlVideoFrames.ResumeLayout(false);
            this.tabControlShotFrames.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControlShotFrames;
        private System.Windows.Forms.TabPage tabShotFrames;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Panel panel1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.TabControl tabControlVideoFrames;
        public System.Windows.Forms.TabPage tabVideoFrames;


    }
}

