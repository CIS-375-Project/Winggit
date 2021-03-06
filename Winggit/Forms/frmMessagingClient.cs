﻿using System;
using System.Media;
using System.Windows.Forms;
using Winggit.Entities;
using Winggit.Controls;
using System.Data;
using System.Collections;

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
        }

        private void btnDeleteMsg_Click(object sender, EventArgs e)
        {
            // delete message
            SystemSounds.Asterisk.Play();
            if (MessageBox.Show(@"This can't be undone. Are you sure?", @"Delete message?", MessageBoxButtons.YesNo) !=
                DialogResult.Yes) return;
            Hashtable oHash = new Hashtable();
            oHash.Add("@MessageID", dgdMsgInbox.SelectedRows[0].Cells[4].Value);
            string sql = "DELETE FROM Messages WHERE MessageID = @MessageID";
            DBFunctions.RunQuery(sql, oHash);
            LoadMessages();
            btnDeleteMsg.Enabled = false;
            btnCompose.Text = @"Compose";
            msgString = "";
        }

        private void btnCompose_Click(object sender, EventArgs e)
        {
            // compose message
            new frmComposeMsg(msgString).ShowDialog();
        }

        private void frmMessagingClient_Load(object sender, EventArgs e)
        {
            // Load the form
            btnCompose.Text = @"Compose";
            LoadMessages();
        }

        private void LoadMessages()
        {
            // load the messages into the table
            Hashtable oHash = new Hashtable();
            oHash.Add("@WingerNum", Winger.currentWinger.WingerNum);
            string sql = "SELECT W.Name as 'Sender', M.Subject, M.TimeStamp, M.Body, M.MessageID, M.Source FROM Messages as M JOIN Wingers as W ON WingerNum = Source WHERE Destination = @WingerNum";
            using (DataSet oDataSet = DBFunctions.GetDataSet(sql, oHash))
            {
                dgdMsgInbox.DataSource = oDataSet.Tables[0];
                dgdMsgInbox.ClearSelection();
                dgdMsgInbox.Columns[4].Visible = false;
                dgdMsgInbox.Columns[5].Visible = false;
                dgdMsgInbox.AllowUserToAddRows = false;
                dgdMsgInbox.ReadOnly = true;
                dgdMsgInbox.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgdMsgInbox.MultiSelect = false;
                dgdMsgInbox.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
                int maxWidth = 200;
                foreach (DataGridViewColumn oColumn in dgdMsgInbox.Columns)
                {
                    if (oColumn.Width > maxWidth)
                    {
                        oColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                        oColumn.Width = maxWidth;
                    }
                }
                txtMsgSender.Text = string.Empty;
                txtMsgSubject.Text = string.Empty;
                txtMsgTimestamp.Text = string.Empty;
                txtMsgContents.Text = string.Empty;
            }
        }

        private void btnRefreshInbox_Click(object sender, EventArgs e)
        {
            // refresh the table
            LoadMessages();
            btnDeleteMsg.Enabled = false;
            btnCompose.Text = @"Compose";
            msgString = "";
        }

        private void dgdMsgInbox_SelectionChanged(object sender, EventArgs e)
        {
            // selected a message, update fields for reading
            if (dgdMsgInbox.SelectedRows.Count > 0)
            {
                btnDeleteMsg.Enabled = true;
                btnCompose.Text = @"Reply";
                txtMsgSender.Text = dgdMsgInbox.SelectedRows[0].Cells[0].Value.ToString();
                txtMsgSubject.Text = dgdMsgInbox.SelectedRows[0].Cells[1].Value.ToString();
                txtMsgTimestamp.Text = dgdMsgInbox.SelectedRows[0].Cells[2].Value.ToString();
                txtMsgContents.Text = dgdMsgInbox.SelectedRows[0].Cells[3].Value.ToString();
                msgString = dgdMsgInbox.SelectedRows[0].Cells[5].Value + " " + dgdMsgInbox.SelectedRows[0].Cells[1].Value;
            }
        }

        private void frmMessagingClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            SystemSounds.Asterisk.Play();
            if (MessageBox.Show(@"About to return to main menu. Proceed?", @"Leave messaging?", MessageBoxButtons.YesNo) ==
                DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
