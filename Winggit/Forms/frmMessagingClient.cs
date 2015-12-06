using System;
using System.Media;
using System.Windows.Forms;

namespace Winggit
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
            if (
                MessageBox.Show(@"Leave Messaging?", @"About to return to main menu. Proceed?", MessageBoxButtons.YesNo) ==
                DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnDeleteMsg_Click(object sender, EventArgs e)
        {
            SystemSounds.Asterisk.Play();
            if (MessageBox.Show(@"Delete Message?", @"This can't be undone. Are you sure?", MessageBoxButtons.YesNo) ==
                DialogResult.Yes)
            {
                // TODO delete message.
            }
        }

        private void btnCompose_Click(object sender, EventArgs e)
        {
            new frmComposeMsg().Show();
        }
    }
}
