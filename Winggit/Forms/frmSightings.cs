using System;
using System.Media;
using System.Windows.Forms;
using Winggit.Enums;

namespace Winggit.Forms
{
    public partial class frmSightings : Form
    {
        public frmSightings()
        {
            InitializeComponent();
            
        }

        private void btnCancelSightings_Click(object sender, EventArgs e)
        {
            SystemSounds.Asterisk.Play();
            if (MessageBox.Show(@"Any info you entered will be lost.", @"Are you sure?", MessageBoxButtons.YesNo) ==
                DialogResult.Yes)
            {
                Close();
            }
        }

        private void txtSightingTagID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSightingTagID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void chkNewTag_CheckedChanged(object sender, EventArgs e)
        {
            txtSightingTagID.Enabled = chkNewTag.Checked;
        }

        private void updLatitude_ValueChanged(object sender, EventArgs e)
        {
            if (updLatitude.Value == 0)
            {
                rdoNorth.Enabled = false;
                rdoSouth.Enabled = false;
            }
            else
            {
                rdoNorth.Enabled = true;
                rdoSouth.Enabled = true;
            }
        }

        private void updLongitude_ValueChanged(object sender, EventArgs e)
        {
            if (updLongitude.Value == 0)
            {
                rdoEast.Enabled = false;
                rdoWest.Enabled = false;
            }
            else
            {
                rdoEast.Enabled = true;
                rdoWest.Enabled = true;
            }
        }

        private void tbcLocationPicker_TabIndexChanged(object sender, EventArgs e)
        {
            if (tbcLocationPicker.SelectedIndex == 0)
            {
            }
            else
            {
                
            }
        }

        private void cmbSightingCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSightingCountry.SelectedIndex > -1)
            {
                cmbSightingStateProv.Enabled = true;
                cmbSightingStateProv.DataSource = Enum.GetValues(cmbSightingCountry.SelectedIndex == 0 ? typeof (States) : typeof (Provinces));
            }
            else
            {
                cmbSightingStateProv.Enabled = false;
            }
        }

        private void cmbSightingStateProv_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnFinishTagSighting_Click(object sender, EventArgs e)
        {

        }
    }
}
