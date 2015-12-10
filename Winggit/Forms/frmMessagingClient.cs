using System;
using System.Media;
using System.Windows.Forms;

namespace Winggit.Forms
{
    public partial class frmMessagingClient : Form
    {
        private string msgString;
        public frmMessagingClient()
        {
            InitializeComponent();
            msgString = "";
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
            if (MessageBox.Show(@"This can't be undone. Are you sure?", @"Delete message?", MessageBoxButtons.YesNo) !=
                DialogResult.Yes) return;
            // TODO delete message.
            btnDeleteMsg.Enabled = false;
            btnCompose.Text = @"Compose";
            msgString = "";
        }

        private void btnCompose_Click(object sender, EventArgs e)
        {
            new frmComposeMsg(msgString).ShowDialog();
        }

        private void frmMessagingClient_Load(object sender, EventArgs e)
        {
            btnCompose.Text = @"Compose";
            // TODO Load messages.
        }

        private void btnRefreshInbox_Click(object sender, EventArgs e)
        {
            dgdMsgInbox.ClearSelection();
            btnDeleteMsg.Enabled = false;
            btnCompose.Text = @"Compose";
            msgString = "";
            // TODO Reload messages.
        }

        private void dgdMsgInbox_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDeleteMsg.Enabled = true;
            btnCompose.Text = @"Reply";
            // TODO Display message contents in appropriate text boxes.
            // TODO Set msgString to "[Sender ID] [Subject]".
        }
    }
}
