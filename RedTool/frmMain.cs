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
            MessageBox.Show("Credits", "Title", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
