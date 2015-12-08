﻿using System;
using System.Data;
using System.Media;
using System.Windows.Forms;
using Winggit.Controls;
using Winggit.Entities;

namespace Winggit.Forms
{
    public partial class frmLogIn : Form
    {
        public frmLogIn()
        {
            InitializeComponent();
        }

        private void btnCancelLogIn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM Wingers WHERE WingerNum = '" + txtLogInID.Text.Trim() + "'";
            using (DataSet oDataSet = DBFunctions.GetDataset(sql))
            {
                if (oDataSet.Tables.Count == 0 || oDataSet.Tables[0].Rows.Count == 0)
                {
                    SystemSounds.Exclamation.Play();
                    MessageBox.Show(@"User not found!", @"Winggit", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
                Winger.currentWinger = new Winger(oDataSet.Tables[0].Rows[0]);
            }
            new frmMain().ShowDialog();
            Close();
        }

        private void txtLogInID_TextChanged(object sender, EventArgs e)
        {
            btnLogIn.Enabled = txtLogInID.Text.Length > 0;
        }

        private void txtLogInID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ensures only numbers are entered.
            }
        }
    }
}
