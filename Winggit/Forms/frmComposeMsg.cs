using System;
using System.Data;
using System.Collections;
using System.Media;
using System.Windows.Forms;
//using Microsoft.ReportingServices.Diagnostics.Internal;
using Winggit.Controls;
using Winggit.Entities;
using Winggit.Enums;


namespace Winggit.Forms
{
    public partial class frmComposeMsg : Form
    {
        private bool isRecipientFull;
        private bool isSubjectFull;
        private bool isBodyFull;
        private bool isSending;

        // Message string format: [Sender ID] [Subject]
        public frmComposeMsg(string msgString)
        {
            isRecipientFull = false;
            isSubjectFull = false;
            isBodyFull = false;
            isSending = false;
            InitializeComponent();
            if (msgString == "") // Composing new message.
                return;
            string[] splitMsgString = msgString.Split(' ');
            Text = @"Reply to " + splitMsgString[0];
            txtNewMsgRecipient.Text = splitMsgString[0];
            txtNewMsgRecipient.Enabled = false;
            isRecipientFull = true;
            txtNewMsgSubject.Text = @"Re: " + splitMsgString[1];
            txtNewMsgSubject.Enabled = false;
            isSubjectFull = true;
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

        private void txtNewMsgBody_TextChanged(object sender, EventArgs e)
        {
            if (txtNewMsgBody.Text.Trim().Length == 0)
            {
                txtNewMsgBody.Text = "";
            }
            isBodyFull = txtNewMsgBody.Text.Length > 0;
            checkIfSendable();
        }

        private void txtNewMsgSubject_TextChanged(object sender, EventArgs e)
        {
            if (txtNewMsgSubject.Text.Trim().Length == 0) //Just whitespace.
            {
                txtNewMsgSubject.Text = "";
            }
            isSubjectFull = txtNewMsgSubject.Text.Length > 0;
            checkIfSendable();
        }

        private void txtNewMsgRecipient_TextChanged(object sender, EventArgs e)
        {
            isRecipientFull = txtNewMsgRecipient.Text.Length > 0;
            checkIfSendable();
        }

        private void btnSendMsg_Click(object sender, EventArgs e)
        {
            Hashtable oHash = new Hashtable();
            string sql;
            if (txtNewMsgRecipient.Enabled) // Sending, so look up recipient.
            {
                
                oHash.Add("@WingerNum", txtNewMsgRecipient.Text);
                sql = "SELECT Name FROM Wingers WHERE WingerNum = @WingerNum";

                using (DataSet oDataSet = DBFunctions.GetDataSet(sql, oHash))
                {
                    if(oDataSet.Tables.Count == 0 || oDataSet.Tables[0].Rows.Count == 0)
                    {
                        MessageBox.Show(@"Not a registered user!", @"Error!", MessageBoxButtons.OK);
                        return;
                    }
                }

            }
           

            oHash = new Hashtable();
            
            
            oHash.Add("@Destination", txtNewMsgRecipient.Text.Trim());
            oHash.Add("@Subject", txtNewMsgSubject.Text.Trim());
            oHash.Add("@Body", txtNewMsgBody.Text.Trim());
            oHash.Add("@Source", Winger.currentWinger.WingerNum);


            sql = "INSERT INTO Messages VALUES (CURRENT_TIMESTAMP, @Body, @Subject, @Source, @Destination)";

            DBFunctions.RunQuery(sql, oHash);

            MessageBox.Show(@"Your message has been sent!", @"Message Sent", MessageBoxButtons.OK);
            isSending = true;
            Close();

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

        private void frmComposeMsg_FormClosing(object sender, FormClosingEventArgs e)
        {
            SystemSounds.Asterisk.Play();
            if (isSending) return;
            if (MessageBox.Show(@"Your message won't be saved. Proceed?", @"Return to inbox?",
                MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
