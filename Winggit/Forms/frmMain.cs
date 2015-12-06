using System;
using System.Media;
using System.Windows.Forms;

namespace Winggit
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, System.EventArgs e)
        {
            new frmTaggerSearch().Show();
        }

        private void btnExit_Click(object sender, System.EventArgs e)
        {
            SystemSounds.Asterisk.Play();
            if (MessageBox.Show(@"Leave Winggit?", @"Are you sure you want to exit Winggit?", MessageBoxButtons.YesNo) ==
                DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnOpenMessaging_Click(object sender, EventArgs e)
        {
            new frmMessagingClient().Show();
        }

        private void btnOpenReports_Click(object sender, EventArgs e)
        {
            new frmReports().Show();
        }
    }
}
