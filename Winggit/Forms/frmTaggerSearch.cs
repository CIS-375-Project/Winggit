using System;
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
        }

        private void cmbSearchCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSearchCountry.SelectedIndex > -1)
            {
                cmbSearchStateProv.Enabled = true;
                cmbSearchStateProv.DataSource =
                    Enum.GetValues(cmbSearchCountry.SelectedIndex == 0 ? typeof (State) : typeof (Province));
                btnSearch.Enabled = true;
            }
            else
            {
                cmbSearchStateProv.Enabled = false;
                btnSearch.Enabled = false;
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
    }
}