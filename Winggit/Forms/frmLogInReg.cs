using System;
using System.Media;
using System.Windows.Forms;

namespace Winggit.Forms
{
    public partial class frmLogInReg : Form
    {
        public frmLogInReg()
        {
            InitializeComponent();
        }

        private void btnGoToLogIn_Click(object sender, EventArgs e)
        {
            new frmLogIn().Show();
        }

        private void btnGoToRegister_Click(object sender, EventArgs e)
        {
            new frmRegister().Show();
        }

        private void btnExitLogInReg_Click(object sender, EventArgs e)
        {
            SystemSounds.Asterisk.Play();
            if (MessageBox.Show(@"Are you sure you want to exit Winggit?", @"Leave Winggit?", MessageBoxButtons.YesNo) ==
                DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
