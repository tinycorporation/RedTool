using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace RedTool
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

            /* Register Button */

            Settings.Username = txtUsername.Text;
            Settings.Password = txtPassword.Text;
            Settings.Email = txtEmail.Text;



            if (string.IsNullOrEmpty(Settings.Username)) return;
            if (string.IsNullOrEmpty(Settings.Password)) return;
            if (string.IsNullOrEmpty(Settings.Email)) return;

            var temp = Extensions.Authentication.Register(
                Settings.Username,
                Settings.Password,
                Settings.Email);


            if (timer1tick < 1)
            {
                dynamic Results = JsonConvert.DeserializeObject(temp);

                switch (bool.Parse(Results.Authenticated.ToString()))
                {
                    case true:
                        MessageBox.Show(Results.Description.ToString());

                        break;

                    case false:
                        MessageBox.Show(Results.Description.ToString());

                        break;

                    default:
                        MessageBox.Show("connection error");

                        break;
                }
            }
            else
            {
                MessageBox.Show("Try again in a moment.");
            }
            timer1.Start();


        }

        int timer1tick = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1tick += 1;
            if (timer1tick > 600)
            {
                timer1tick = 0;
                timer1.Stop();
            }
        }

        private void btnRegister2_Click(object sender, EventArgs e)
        {
            var FormLogin = new frmLogin();
            Hide();
            FormLogin.Closed += (s, args) => Close();
            FormLogin.Show();
        }




        bool Clicked1 = false;
        private void txtUsername_Click(object sender, EventArgs e)
        {
            if (Clicked1 == false)
            {
                txtUsername.Clear();
                Clicked1 = true;
            }
            txtUsername.ForeColor = Color.FromArgb(78, 184, 206);
            
            txtPassword.ForeColor = Color.WhiteSmoke;

        }

        bool Clicked2 = false;
        private void txtPassword_Click(object sender, EventArgs e)
        {
            if (Clicked2 == false)
            {
                txtPassword.Clear();
                Clicked2 = true;
            }
            txtPassword.PasswordChar = '●';
            txtPassword.ForeColor = Color.FromArgb(78, 184, 206);
            
            txtUsername.ForeColor = Color.WhiteSmoke;
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (Clicked2 == false)
            {
                txtPassword.Clear();
                Clicked2 = true;
            }
            txtPassword.PasswordChar = '●';
            txtPassword.ForeColor = Color.FromArgb(78, 184, 206);
            
            txtUsername.ForeColor = Color.WhiteSmoke;
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (Clicked1 == false)
            {
                txtUsername.Clear();
                Clicked1 = true;
            }
            txtUsername.ForeColor = Color.FromArgb(78, 184, 206);

            txtPassword.ForeColor = Color.WhiteSmoke;
        }

        bool Clicked3 = false;
        private void txtEmail_Click(object sender, EventArgs e)
        {
            if (Clicked3 == false)
            {
                txtEmail.Clear();
                Clicked3 = true;
            }
            txtEmail.ForeColor = Color.FromArgb(78, 184, 206);

            txtUsername.ForeColor = Color.WhiteSmoke;
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (Clicked2 == false)
            {
                txtEmail.Clear();
                Clicked2 = true;
            }
            txtEmail.ForeColor = Color.FromArgb(78, 184, 206);

            txtUsername.ForeColor = Color.WhiteSmoke;
        }




        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        void frmRegister_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }


}
