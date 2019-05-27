using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedTool
{
    public partial class frmMain : Form
    {
        int PW;
        bool Hidden;
        public frmMain()
        {
            InitializeComponent();
            PW = panel1.Width;
            Hidden = false;

            if (Settings.Admin == 1)
            {
                lblAdmin.Visible = true;
            }
            else if (Settings.Admin == 0)
            {
                lblAdmin.Visible = false;
            }
        }

        private void picHidden_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Hidden) {
                panel1.Width += 200;
                if (panel1.Width >= PW)
                {
                    panel1.Width = PW;
                    timer1.Stop();
                    Hidden = false;
                    picHidden.Image = Properties.Resources.hide;
                    this.Refresh();
                }
            } else{
                panel1.Width -= 200;
                if (panel1.Width <= 32)
                {
                    panel1.Width = 32;
                    timer1.Stop();
                    Hidden = true;
                    picHidden.Image = Properties.Resources.view;
                    this.Refresh();

                }
            }
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void lblCredits_Click(object sender, EventArgs e)
        {
            MessageBox.Show("https://www.flaticon.com for icons used.", "Credits", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        bool Settings1 = false;

        private void lblSettings_Click(object sender, EventArgs e)
        {
            if(Settings1 == false)
            {
                panel5.Visible = true;
                Settings1 = true;
            }
            else
            {
                panel5.Visible = false;
                Settings1 = false;
            }
        }

        private void picSettings_Click(object sender, EventArgs e)
        {
            if (Settings1 == false)
            {
                panel5.Visible = true;
                Settings1 = true;
            }
            else
            {
                panel5.Visible = false;
                Settings1 = false;
            }
        }

        private void picLogOut_Click(object sender, EventArgs e)
        {
            var FormLogin = new frmLogin();
            Hide();
            FormLogin.Closed += (s, args) => Close();
            FormLogin.Show();
        }

        private void lblLogOut_Click(object sender, EventArgs e)
        {
            var FormLogin = new frmLogin();
            Hide();
            FormLogin.Closed += (s, args) => Close();
            FormLogin.Show();
        }

        private void LblAdmin_Click(object sender, EventArgs e)
        {
            var FormAdmin = new frmAdmin();
            Hide();
            FormAdmin.Show();
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                panel3.BackColor = Color.FromArgb(45, 45, 45);
                panel4.BackColor = Color.FromArgb(34, 34, 34);
                panel5.BackColor = Color.FromArgb(40, 40, 40);
                checkBox1.ForeColor = Color.FromArgb(170, 170, 170);
                lblSettings.ForeColor = Color.FromArgb(170, 170, 170);
                picSettings.BackgroundImage = Properties.Resources.settings_grey;
            }
            else
            {
                panel3.BackColor = Color.LightGray;
                panel4.BackColor = Color.WhiteSmoke;
                panel5.BackColor = Color.Gainsboro;
                checkBox1.ForeColor = Color.FromArgb(0, 0, 0);
                lblSettings.ForeColor = Color.FromArgb(0, 0, 0);
                picSettings.BackgroundImage = Properties.Resources.settings_black;
            }
        }
    }
}
