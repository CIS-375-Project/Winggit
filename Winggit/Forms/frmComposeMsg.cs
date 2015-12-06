using System;
using System.Media;
using System.Windows.Forms;

namespace Winggit.Forms
{
    public partial class frmComposeMsg : Form
    {
        public frmComposeMsg()
        {
            InitializeComponent();
        }

        private void btnCancelCompose_Click(object sender, EventArgs e)
        {
            SystemSounds.Asterisk.Play();
            if (MessageBox.Show(@"Return to inbox?", @"Your message won't be saved. Proceed?", MessageBoxButtons.YesNo) ==
                DialogResult.Yes)
            {
                Close();
            }
        }

        private void txtNewMsgBody_TextChanged(object sender, EventArgs e)
        {
            if (txtNewMsgRecipient.Text.Length > 0 && txtNewMsgSubject.Text.Length > 0)
            {
                btnSendMsg.Enabled = true;
            }
            else
            {
                btnSendMsg.Enabled = false;
            }
        }

        private void txtNewMsgSubject_TextChanged(object sender, EventArgs e)
        {
            if (txtNewMsgBody.Text.Length > 0 && txtNewMsgRecipient.Text.Length > 0)
            {
                btnSendMsg.Enabled = true;
            }
            else
            {
                btnSendMsg.Enabled = false;
            }
        }

        private void txtNewMsgRecipient_TextChanged(object sender, EventArgs e)
        {
            if (txtNewMsgBody.Text.Length > 0 && txtNewMsgSubject.Text.Length > 0)
            {
                btnSendMsg.Enabled = true;
            }
            else
            {
                btnSendMsg.Enabled = false;
            }
        }

        private void btnSendMsg_Click(object sender, EventArgs e)
        {
            // TODO Verify that recipient exists before sending message.
        }

        private void txtNewMsgRecipient_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
