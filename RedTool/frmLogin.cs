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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            try
            {
                if (!System.IO.Directory.Exists(System.IO.Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "RedTool")))
                {
                    System.IO.Directory.CreateDirectory(System.IO.Path.Combine(
                        Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "RedTool"));

                    return;
                }

                var streamReader = new System.IO.StreamReader(System.IO.Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "RedTool\\Credentials")
                );

                txtUsername.Text = Extensions.Other.Base64Decode(streamReader.ReadLine());
                txtPassword.Text = Extensions.Other.Base64Decode(streamReader.ReadLine());

                streamReader.Close();
            }
            catch { }

            if (!(txtPassword.Text == "Password"))
            {
                txtPassword.PasswordChar = '●';
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            /* Login Button */

            LoginMethod();

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var FormRegister = new frmRegister();
            Hide();
            FormRegister.Closed += (s, args) => Close();
            FormRegister.Show();
        }
        bool Clicked1 = false;
        private void txtUsername_Click(object sender, EventArgs e)
        {
            if (Clicked1 == false)
            {
                txtUsername.Clear();
                Clicked1 = true;
            }
            panel1.ForeColor = Color.FromArgb(78, 184, 206);
            txtUsername.ForeColor = Color.FromArgb(78, 184, 206);

            panel2.ForeColor = Color.WhiteSmoke;
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
            panel2.ForeColor = Color.FromArgb(78, 184, 206);
            txtPassword.ForeColor = Color.FromArgb(78, 184, 206);

            panel1.ForeColor = Color.WhiteSmoke;
            txtUsername.ForeColor = Color.WhiteSmoke;
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (Clicked2 == false)
            {
                txtPassword.Clear();
                Clicked2 = true;
            }
            txtPassword.PasswordChar = '●';
            panel2.ForeColor = Color.FromArgb(78, 184, 206);
            txtPassword.ForeColor = Color.FromArgb(78, 184, 206);

            panel1.ForeColor = Color.WhiteSmoke;
            txtUsername.ForeColor = Color.WhiteSmoke;
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (Clicked1 == false)
            {
                txtUsername.Clear();
                Clicked1 = true;
            }
            txtPassword.PasswordChar = '●';
            panel2.ForeColor = Color.FromArgb(78, 184, 206);
            txtPassword.ForeColor = Color.FromArgb(78, 184, 206);

            panel1.ForeColor = Color.WhiteSmoke;
            txtUsername.ForeColor = Color.WhiteSmoke;
        }

        public void LoginMethod()
        {
            Settings.Username = txtUsername.Text;
            Settings.Password = txtPassword.Text;

            if (string.IsNullOrEmpty(Settings.Username)) return;
            if (string.IsNullOrEmpty(Settings.Password)) return;


            var temp = Extensions.Authentication.Login(
                Settings.Username,
                Settings.Password);

            dynamic Results = JsonConvert.DeserializeObject(temp);

            Settings.Username = Results.Username.ToString();

            switch (int.Parse(Results.Administrator.ToString()))
            {
                case 1:
                    Settings.Admin = 1;

                    break;

                case 0:
                    Settings.Admin = 0;

                    break;
            }



            switch (bool.Parse(Results.Authenticated.ToString()))
            {
                case true:



                    if (chkRemember.Checked == true)
                    {
                        var StreamWriter = new System.IO.StreamWriter(System.IO.Path.Combine(
                        Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "RedTool\\Credentials")
                    );
                        StreamWriter.WriteLine(Extensions.Other.Base64Encode(Settings.Username));
                        StreamWriter.WriteLine(Extensions.Other.Base64Encode(Settings.Password));
                        StreamWriter.Close();
                    }




                    MessageBox.Show(Results.Description.ToString());

                    var Form2 = new frmMain();
                    Hide();
                    Form2.Closed += (s, args) => Close();
                    Form2.Show();


                    // System.Diagnostics.Process.Start("http://192.168.1.106/webmail");


                    break;

                case false:
                    MessageBox.Show(Results.Description.ToString());

                    break;

                default:
                    MessageBox.Show("connection error");

                    break;
            }
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                LoginMethod();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                LoginMethod();
            }
        }
    }
}
