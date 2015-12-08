using System;
using System.Media;
using System.Windows.Forms;

namespace Winggit.Forms
{
    public partial class frmMessagingClient : Form
    {
        public frmMessagingClient()
        {
            InitializeComponent();
        }

        private void btnCancelMessaging_Click(object sender, EventArgs e)
        {
            SystemSounds.Asterisk.Play();
            if (MessageBox.Show(@"About to return to main menu. Proceed?", @"Leave messaging?", MessageBoxButtons.YesNo) ==
                DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnDeleteMsg_Click(object sender, EventArgs e)
        {
            SystemSounds.Asterisk.Play();
            if (MessageBox.Show(@"This can't be undone. Are you sure?", @"Delete message?", MessageBoxButtons.YesNo) ==
                DialogResult.Yes)
            {
                // TODO delete message.
            }
        }

        private void btnCompose_Click(object sender, EventArgs e)
        {
            new frmComposeMsg().ShowDialog();
        }
    }
}
