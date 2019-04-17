using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace project_AquaLumia
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pbSlpash.Value < 100)
            {
                pbSlpash.Value = pbSlpash.Value + 2;

            }
            else
            {
                timer1.Enabled = false;

                frmMenu vemMenu = new frmMenu();
                this.Hide();
                vemMenu.ShowDialog();
                this.Close();
            }
        }

        
    }
}
