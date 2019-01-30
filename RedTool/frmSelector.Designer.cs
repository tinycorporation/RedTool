namespace RedTool
{
    partial class frmSelector
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
            this.rbDev = new System.Windows.Forms.RadioButton();
            this.rbStable = new System.Windows.Forms.RadioButton();
            this.btnLoad = new System.Windows.Forms.Button();
            this.lblUsernameText = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblExpiresText = new System.Windows.Forms.Label();
            this.lblExpires = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rbDev
            // 
            this.rbDev.AutoSize = true;
            this.rbDev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.rbDev.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDev.ForeColor = System.Drawing.SystemColors.Control;
            this.rbDev.Location = new System.Drawing.Point(227, 51);
            this.rbDev.Name = "rbDev";
            this.rbDev.Size = new System.Drawing.Size(80, 20);
            this.rbDev.TabIndex = 0;
            this.rbDev.TabStop = true;
            this.rbDev.Text = "Dev Build";
            this.rbDev.UseVisualStyleBackColor = false;
            this.rbDev.CheckedChanged += new System.EventHandler(this.rbDev_CheckedChanged);
            // 
            // rbStable
            // 
            this.rbStable.AutoSize = true;
            this.rbStable.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbStable.ForeColor = System.Drawing.SystemColors.Control;
            this.rbStable.Location = new System.Drawing.Point(227, 87);
            this.rbStable.Name = "rbStable";
            this.rbStable.Size = new System.Drawing.Size(96, 20);
            this.rbStable.TabIndex = 1;
            this.rbStable.TabStop = true;
            this.rbStable.Text = "Stable Build";
            this.rbStable.UseVisualStyleBackColor = true;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(55, 172);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(276, 23);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "Launch";
            this.btnLoad.UseVisualStyleBackColor = true;
            // 
            // lblUsernameText
            // 
            this.lblUsernameText.AutoSize = true;
            this.lblUsernameText.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsernameText.ForeColor = System.Drawing.SystemColors.Control;
            this.lblUsernameText.Location = new System.Drawing.Point(32, 55);
            this.lblUsernameText.Name = "lblUsernameText";
            this.lblUsernameText.Size = new System.Drawing.Size(75, 16);
            this.lblUsernameText.TabIndex = 3;
            this.lblUsernameText.Text = "Username -";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.SystemColors.Control;
            this.lblUsername.Location = new System.Drawing.Point(113, 55);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(40, 16);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "NULL";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 38);
            this.label1.TabIndex = 5;
            this.label1.Text = "RedTool";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblExpiresText
            // 
            this.lblExpiresText.AutoSize = true;
            this.lblExpiresText.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpiresText.ForeColor = System.Drawing.SystemColors.Control;
            this.lblExpiresText.Location = new System.Drawing.Point(32, 87);
            this.lblExpiresText.Name = "lblExpiresText";
            this.lblExpiresText.Size = new System.Drawing.Size(76, 16);
            this.lblExpiresText.TabIndex = 6;
            this.lblExpiresText.Text = "Expires     -";
            // 
            // lblExpires
            // 
            this.lblExpires.AutoSize = true;
            this.lblExpires.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpires.ForeColor = System.Drawing.SystemColors.Control;
            this.lblExpires.Location = new System.Drawing.Point(113, 87);
            this.lblExpires.Name = "lblExpires";
            this.lblExpires.Size = new System.Drawing.Size(40, 16);
            this.lblExpires.TabIndex = 4;
            this.lblExpires.Text = "NULL";
            // 
            // frmSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(365, 220);
            this.Controls.Add(this.lblExpiresText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblExpires);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblUsernameText);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.rbStable);
            this.Controls.Add(this.rbDev);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSelector";
            this.Text = "frmSelectore";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbDev;
        private System.Windows.Forms.RadioButton rbStable;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label lblUsernameText;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblExpiresText;
        private System.Windows.Forms.Label lblExpires;
    }
}