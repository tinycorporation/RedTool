namespace RedTool
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblLogOut = new System.Windows.Forms.Label();
            this.picLogOut = new System.Windows.Forms.PictureBox();
            this.lblCredits = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picHidden = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.picSettings = new System.Windows.Forms.PictureBox();
            this.lblSettings = new System.Windows.Forms.Label();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogOut)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHidden)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Indigo;
            this.panel1.Controls.Add(this.lblLogOut);
            this.panel1.Controls.Add(this.picLogOut);
            this.panel1.Controls.Add(this.lblCredits);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(214, 513);
            this.panel1.TabIndex = 0;
            // 
            // lblLogOut
            // 
            this.lblLogOut.AutoSize = true;
            this.lblLogOut.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogOut.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblLogOut.Location = new System.Drawing.Point(30, 488);
            this.lblLogOut.Name = "lblLogOut";
            this.lblLogOut.Size = new System.Drawing.Size(54, 16);
            this.lblLogOut.TabIndex = 3;
            this.lblLogOut.Text = "Log Out";
            this.lblLogOut.Click += new System.EventHandler(this.lblLogOut_Click);
            // 
            // picLogOut
            // 
            this.picLogOut.Image = global::RedTool.Properties.Resources.logout;
            this.picLogOut.Location = new System.Drawing.Point(3, 478);
            this.picLogOut.Name = "picLogOut";
            this.picLogOut.Size = new System.Drawing.Size(32, 32);
            this.picLogOut.TabIndex = 2;
            this.picLogOut.TabStop = false;
            this.picLogOut.Click += new System.EventHandler(this.picLogOut_Click);
            // 
            // lblCredits
            // 
            this.lblCredits.AutoSize = true;
            this.lblCredits.Location = new System.Drawing.Point(169, 491);
            this.lblCredits.Name = "lblCredits";
            this.lblCredits.Size = new System.Drawing.Size(39, 13);
            this.lblCredits.TabIndex = 1;
            this.lblCredits.Text = "Credits";
            this.lblCredits.Click += new System.EventHandler(this.lblCredits_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.picHidden);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(214, 32);
            this.panel2.TabIndex = 0;
            // 
            // picHidden
            // 
            this.picHidden.Dock = System.Windows.Forms.DockStyle.Left;
            this.picHidden.Image = global::RedTool.Properties.Resources.hide;
            this.picHidden.Location = new System.Drawing.Point(0, 0);
            this.picHidden.Name = "picHidden";
            this.picHidden.Size = new System.Drawing.Size(32, 32);
            this.picHidden.TabIndex = 0;
            this.picHidden.TabStop = false;
            this.picHidden.Click += new System.EventHandler(this.picHidden_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(214, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(560, 513);
            this.panel4.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Location = new System.Drawing.Point(424, 38);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(113, 184);
            this.panel5.TabIndex = 0;
            this.panel5.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel3.Controls.Add(this.picSettings);
            this.panel3.Controls.Add(this.lblSettings);
            this.panel3.Controls.Add(this.picExit);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(214, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(560, 32);
            this.panel3.TabIndex = 3;
            // 
            // picSettings
            // 
            this.picSettings.BackgroundImage = global::RedTool.Properties.Resources.VisualEditor___Icon___Advanced_svg;
            this.picSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picSettings.Dock = System.Windows.Forms.DockStyle.Right;
            this.picSettings.Image = global::RedTool.Properties.Resources.VisualEditor___Icon___Advanced_svg;
            this.picSettings.Location = new System.Drawing.Point(424, 0);
            this.picSettings.Name = "picSettings";
            this.picSettings.Size = new System.Drawing.Size(32, 32);
            this.picSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picSettings.TabIndex = 1;
            this.picSettings.TabStop = false;
            this.picSettings.Click += new System.EventHandler(this.picSettings_Click);
            // 
            // lblSettings
            // 
            this.lblSettings.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblSettings.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSettings.Location = new System.Drawing.Point(456, 0);
            this.lblSettings.Name = "lblSettings";
            this.lblSettings.Size = new System.Drawing.Size(72, 32);
            this.lblSettings.TabIndex = 2;
            this.lblSettings.Text = "Settings";
            this.lblSettings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSettings.Click += new System.EventHandler(this.lblSettings_Click);
            // 
            // picExit
            // 
            this.picExit.BackgroundImage = global::RedTool.Properties.Resources.error;
            this.picExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.picExit.Location = new System.Drawing.Point(528, 0);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(32, 32);
            this.picExit.TabIndex = 0;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 513);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogOut)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picHidden)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picHidden;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.Label lblCredits;
        private System.Windows.Forms.PictureBox picSettings;
        private System.Windows.Forms.Label lblSettings;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblLogOut;
        private System.Windows.Forms.PictureBox picLogOut;
    }
}