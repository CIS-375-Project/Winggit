using System;
using System.Media;
using System.Windows.Forms;
using Winggit.Entities;

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
            new frmLogIn().ShowDialog();
            if (Winger.currentWinger == null)
                return;
            Hide();
            new frmMain().ShowDialog();
            Close();
        }

        private void btnGoToRegister_Click(object sender, EventArgs e)
        {
            new frmRegister(false).ShowDialog();
            if (Winger.currentWinger == null)
                return;
            Hide();
            new frmMain().ShowDialog();
            Close();
        }

        private void frmLogInReg_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.ApplicationExitCall)
            {
                SystemSounds.Asterisk.Play();
                if (MessageBox.Show(@"Are you sure you want to exit Winggit?", @"Leave Winggit?",
                    MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void btnExitLogInReg_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
