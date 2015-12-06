using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winggit
{
    public partial class frmComposeMsg : Form
    {
        public frmComposeMsg()
        {
            InitializeComponent();
        }

        private void btnCancelCompose_Click(object sender, EventArgs e)
        {
            Close();
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
