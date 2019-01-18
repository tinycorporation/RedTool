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
    { //test
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
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            /* Login Button */

            Settings.Username = txtUsername.Text;
            Settings.Password = txtPassword.Text;

            if (string.IsNullOrEmpty(Settings.Username)) return;
            if (string.IsNullOrEmpty(Settings.Password)) return;


            var temp = Extensions.Authentication.Login(
                Settings.Username,
                Settings.Password);

            dynamic Results = JsonConvert.DeserializeObject(temp);

            Settings.Username = Results.Username.ToString();

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

        private void btnRegister_Click(object sender, EventArgs e)
        {

            /* Register Button */
            if (txtUsername.MaxLength < 20)

            {
                Settings.Username = txtUsername.Text;
                Settings.Password = txtPassword.Text;
            }
            else
            {
                MessageBox.Show("Username is too long or too short.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            if (string.IsNullOrEmpty(Settings.Username)) return;
            if (string.IsNullOrEmpty(Settings.Password)) return;


            var temp = Extensions.Authentication.Register(
                Settings.Username,
                Settings.Password);

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

        private void txtUsername_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            panel1.ForeColor = Color.FromArgb(78, 184, 206);
            txtUsername.ForeColor = Color.FromArgb(78, 184, 206);

            panel2.ForeColor = Color.WhiteSmoke;
            txtPassword.ForeColor = Color.WhiteSmoke;

        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
            txtPassword.PasswordChar = '●';
            panel2.ForeColor = Color.FromArgb(78, 184, 206);
            txtPassword.ForeColor = Color.FromArgb(78, 184, 206);

            panel1.ForeColor = Color.WhiteSmoke;
            txtUsername.ForeColor = Color.WhiteSmoke;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txtPassword.Clear();
            txtPassword.PasswordChar = '●';
            panel2.ForeColor = Color.FromArgb(78, 184, 206);
            txtPassword.ForeColor = Color.FromArgb(78, 184, 206);

            panel1.ForeColor = Color.WhiteSmoke;
            txtUsername.ForeColor = Color.WhiteSmoke;
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            txtPassword.Clear();
            txtPassword.PasswordChar = '●';
            panel2.ForeColor = Color.FromArgb(78, 184, 206);
            txtPassword.ForeColor = Color.FromArgb(78, 184, 206);

            panel1.ForeColor = Color.WhiteSmoke;
            txtUsername.ForeColor = Color.WhiteSmoke;
        }
    }
}
