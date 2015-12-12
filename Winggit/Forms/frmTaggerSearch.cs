using System;
using System.Collections;
using System.Media;
using System.Windows.Forms;
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
            Hashtable oHash = new Hashtable();
            
        }

        private void cmbSearchCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSearchCountry.SelectedIndex > 0)
            {
                cmbSearchStateProv.Enabled = true;
                cmbSearchStateProv.DataSource =
                    Enum.GetValues(cmbSearchCountry.SelectedIndex == 1 ? typeof (State) : typeof (Province));
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