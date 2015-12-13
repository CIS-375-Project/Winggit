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
            if (rdoSearchByLocation.Checked)
            {
                if (txtSearchCity.Text.Length > 0)
                {
                    oHash.Add("@City", txtSearchCity.Text);
                    sql += " City like '%' + @City + '%'";
                    count++;
                }
                if (cmbSearchCountry.SelectedIndex > 0)
                {
                    if (count > 0)
                    {
                        sql += " AND";
                    }
                    oHash.Add("@Country", cmbSearchCountry.SelectedItem.ToString());
                    sql += " Country like '%' + @Country + '%'";
                    if (cmbSearchStateProv.SelectedIndex > 0)
                    {
                        oHash.Add("@State", cmbSearchStateProv.SelectedItem.ToString());
                        sql += " AND State like '%' + @State + '%'";
                    }
                }
            }
            else
            {
                if (txtSearchName.Text.Length > 0)
                {
                    oHash.Add("@Name", txtSearchName.Text.Trim());
                    sql += " Name like '%' + @Name + '%'";
                    count++;
                }
                if (txtSearchTaggerID.Text.Length > 0)
                {
                    if (count > 0)
                    {
                        sql += " AND";
                    }
                    oHash.Add("@TaggerID", txtSearchTaggerID.Text.Trim());
                    sql += " WingerNum like '%' + @TaggerID + '%'";
                }
            }
            using (DataSet oDataSet = DBFunctions.GetDataSet(sql, oHash))
            {
                if (oDataSet.Tables.Count == 0 || oDataSet.Tables[0].Rows.Count == 0)
                {
                    return;
                }
                dgdTaggerSearchResults.DataSource = oDataSet.Tables[0];
                dgdTaggerSearchResults.ClearSelection();
                dgdTaggerSearchResults.AllowUserToAddRows = false;
                dgdTaggerSearchResults.ReadOnly = true;
                dgdTaggerSearchResults.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgdTaggerSearchResults.MultiSelect = false;
                dgdTaggerSearchResults.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
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
                btnSearch.Enabled = txtSearchCity.Text.Trim().Length > 0;
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
            btnSearch.Enabled = cmbSearchStateProv.SelectedIndex > 0 || txtSearchCity.Text.Trim().Length > 0;
        }

        private void rdoSearchByLocation_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoSearchByLocation.Checked)
            {
                grpByLocation.Enabled = true;
                grpByTaggerInfo.Enabled = false;
                btnSearch.Enabled = txtSearchCity.Text.Trim().Length > 0 || cmbSearchCountry.SelectedIndex > 0;
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
                btnSearch.Enabled = txtSearchName.Text.Trim().Length > 0 || txtSearchTaggerID.Text.Length > 0;
            }
            else
            {
                grpByLocation.Enabled = true;
                grpByTaggerInfo.Enabled = false;
            }
        }

        private void txtSearchName_TextChanged(object sender, EventArgs e)
        {
            btnSearch.Enabled = txtSearchName.Text.Trim().Length + txtSearchTaggerID.Text.Length > 0;
        }

        private void txtSearchTaggerID_TextChanged(object sender, EventArgs e)
        {
            btnSearch.Enabled = txtSearchTaggerID.Text.Length + txtSearchName.Text.Trim().Length > 0;
        }

        private void txtSearchCity_TextChanged(object sender, EventArgs e)
        {
            btnSearch.Enabled = txtSearchCity.Text.Trim().Length > 0 || cmbSearchCountry.SelectedIndex > 0;
        }
    }
}