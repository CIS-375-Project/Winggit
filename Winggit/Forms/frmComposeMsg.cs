using System;
using System.Media;
using System.Windows.Forms;
using Winggit.Enums;

namespace Winggit.Forms
{
    public partial class frmComposeMsg : Form
    {
        private bool isRecipientFull;
        private bool isSubjectFull;
        private bool isBodyFull;

        // Message string format: [Sender ID] [Subject]
        public frmComposeMsg(string msgString)
        {
            isRecipientFull = false;
            isSubjectFull = false;
            isBodyFull = false;
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
            isBodyFull = txtNewMsgBody.Text.Length > 0;
            checkIfSendable();
        }

        private void txtNewMsgSubject_TextChanged(object sender, EventArgs e)
        {
            if (!isSubjectFull && txtNewMsgSubject.Text.Trim().Length == 0) //Just whitespace.
            isSubjectFull = txtNewMsgSubject.Text.Length > 0;
            checkIfSendable();
            State michigan = State.Michigan;
            switch (michigan)
            {
            }
        }

        private void txtNewMsgRecipient_TextChanged(object sender, EventArgs e)
        {
            isRecipientFull = txtNewMsgRecipient.Text.Length > 0;
            checkIfSendable();
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

        private void checkIfSendable()
        {
            btnSendMsg.Enabled = isBodyFull && isRecipientFull && isSubjectFull;
        }
    }
}
