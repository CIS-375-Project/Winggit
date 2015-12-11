using System;
using System.Media;
using System.Windows.Forms;

namespace Winggit.Forms
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, System.EventArgs e)
        {
            new frmTaggerSearch().ShowDialog();
        }

        private void btnExit_Click(object sender, System.EventArgs e)
        {
            SystemSounds.Asterisk.Play();
            if (MessageBox.Show(@"Are you sure you want to exit Winggit?", @"Leave Winggit?", MessageBoxButtons.YesNo) ==
                DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnOpenMessaging_Click(object sender, EventArgs e)
        {
            new frmMessagingClient().ShowDialog();
        }

        private void btnOpenReports_Click(object sender, EventArgs e)
        {
            new frmReports().ShowDialog();
        }

        private void btnOpenSightings_Click(object sender, EventArgs e)
        {
            new frmSightings().ShowDialog();
        }

        private void btnOpenPokedex_Click(object sender, EventArgs e)
        {
            new frmPokedex().ShowDialog();
        }

        private void btnGoToPokedex_Click(object sender, EventArgs e)
        {
            new frmPokedex().ShowDialog();
        }
    }
}
