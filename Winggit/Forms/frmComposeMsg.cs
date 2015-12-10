using System;
using System.Media;
using System.Reflection;
using System.Windows.Forms;

namespace Winggit.Forms
{
    public partial class frmComposeMsg : Form
    {
        // Message string format: [Sender ID] [Subject]
        public frmComposeMsg(string msgString)
        {
            InitializeComponent();
            if (msgString == "") // Composing new message.
                return;
            string[] splitMsgString = msgString.Split(' ');
            Text = @"Reply to " + splitMsgString[0];
            txtNewMsgRecipient.Text = splitMsgString[0];
            txtNewMsgRecipient.Enabled = false;
            txtNewMsgSubject.Text = @"Re: " + splitMsgString[1];
            txtNewMsgSubject.Enabled = false;
        }

        public sealed override string Text
        {
            get
            {
                return base.Text;
            }
            set
            {
                base.Text = value;
            }
        }

        private void btnCancelCompose_Click(object sender, EventArgs e)
        {
            SystemSounds.Asterisk.Play();
            if (MessageBox.Show(@"Your message won't be saved. Proceed?", @"Return to inbox?", MessageBoxButtons.YesNo) ==
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
            if (txtNewMsgRecipient.Enabled) // Sending, so look up recipient.
            {
                // TODO check if recipient exists.
            }
            // TODO send message to recipient.
            // TODO give acknowledgement to sender.
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
