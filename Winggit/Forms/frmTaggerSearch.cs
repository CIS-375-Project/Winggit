using System;
using System.Collections;
using System.Data;
using System.Media;
using System.Windows.Forms;
using Winggit.Controls;
using Winggit.Enums;

namespace Winggit.Forms
{
    public partial class frmTaggerSearch : Form
    {
        public frmTaggerSearch()
        {
            InitializeComponent();
        }

        private void btnCancelSearch_Click(object sender, EventArgs e)
        {
        }

        private void txtSearchTaggerID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // TODO Search for taggers.
            int count = 0;
            Hashtable oHash = new Hashtable();
            string sql = "SELECT * From Wingers WHERE";
            if (txtSearchCity.Text.Length > 0)
            {
                oHash.Add("@City", txtSearchCity.Text);
                sql += " City = @City";
                count++;
            }
            if (cmbSearchCountry.SelectedIndex > 0)
            {
                if (count > 0)
                {
                    sql += " AND";
                }
                oHash.Add("@Country", cmbSearchCountry.SelectedItem.ToString());
                sql += " Country = @Country";
                if (cmbSearchStateProv.SelectedIndex > 0)
                {
                    oHash.Add("@State", cmbSearchStateProv.SelectedItem.ToString());
                    sql += " AND State = @State";
                }
            }
            using (DataSet oDataSet = DBFunctions.GetDataSet(sql, oHash))
            {
                if (oDataSet.Tables.Count == 0 || oDataSet.Tables[0].Rows.Count == 0)
                {
                    return;
                }
                dgdTaggerSearchResults.DataSource = oDataSet.Tables[0];
            }
        }

        private void cmbSearchCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSearchCountry.SelectedIndex > 0)
            {
                cmbSearchStateProv.Enabled = true;
                cmbSearchStateProv.DataSource =
                    Enum.GetValues(cmbSearchCountry.SelectedIndex == 1 ? typeof (State) : typeof (Province));
                btnSearch.Enabled = true;
            }
            else
            {
                cmbSearchStateProv.Enabled = false;
                btnSearch.Enabled = false;
                cmbSearchStateProv.SelectedIndex = -1;
            }
        }

        private void frmTaggerSearch_Load(object sender, EventArgs e)
        {
            cmbSearchCountry.DataSource = Enum.GetValues(typeof (Country));
        }

        private void frmTaggerSearch_FormClosing(object sender, FormClosingEventArgs e)
        {
            SystemSounds.Asterisk.Play();
            if (MessageBox.Show(@"Any info you entered will be lost.", @"Are you sure?", MessageBoxButtons.YesNo) ==
                DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void cmbSearchStateProv_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSearch.Enabled = cmbSearchStateProv.SelectedIndex > 0;
        }

        private void rdoSearchByLocation_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoSearchByLocation.Checked)
            {
                grpByLocation.Enabled = true;
                grpByTaggerInfo.Enabled = false;
            }
            else
            {
                grpByLocation.Enabled = false;
                grpByTaggerInfo.Enabled = true;
            }
        }

        private void rdoSearchByTaggerInfo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoSearchByTaggerInfo.Checked)
            {
                grpByLocation.Enabled = false;
                grpByTaggerInfo.Enabled = true;
            }
            else
            {
                grpByLocation.Enabled = true;
                grpByTaggerInfo.Enabled = false;
            }
        }
    }
}