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
    public partial class frmSelector : Form
    {
        static bool Dev = false;
        static bool Stable = true;

        public frmSelector()
        {
            InitializeComponent();

            if (Settings.Devstatus == 1)
            {
                rbDev.Visible = true;
            }
            else
            {
                rbDev.Visible = false;
            }
        }

        private void rbDev_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
