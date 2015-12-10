using System;
using System.CodeDom;
using System.Linq;
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
            // TODO check if we have enough info to enable finish button. (call method)
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
            txtSightingTagID.Enabled = !chkNewTag.Checked;
            txtSightingSpecies.Enabled = chkNewTag.Checked;
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
                cmbSightingStateProv.DataSource = Enum.GetValues(cmbSightingCountry.SelectedIndex == 0 ? typeof (State) : typeof (Province));
            }
            else
            {
                cmbSightingStateProv.Enabled = false;
            }
        }

        private void cmbSightingStateProv_SelectedIndexChanged(object sender, EventArgs e)
        {
            // TODO Check if city, temperature, and temperature system are entered. (possibly also that tab index is 1).
            // TODO If true, then enable finish button. Otherwise, disable finish button.
        }

        private void btnFinishTagSighting_Click(object sender, EventArgs e)
        {
            if (chkNewTag.Checked)
            {
                // TODO Make new tag.
                MessageBox.Show(@"Registered under Tag ID #[tag]", @"Butterfly tagged!", MessageBoxButtons.OK);
            }
            else
            {
                // TODO Check if tag ID exists.
            }
            // TODO Add sighting.
            int temperature = (int) updTemperature.Value;
        }

        private bool hasEnoughInfo()
        {
            //TODO Check if any temperature system button is pressed. If not, return false.
            //TODO If lat/long tab is pressed, check if lat and long are pressed if lat or long are not equal to 0.
            //TODO If location tab is pressed, check if comboboxes and textboxes have something.
            //TODO IF anything above is false, return false. Otherwise, return true.
            return true; // TODO remove when implemented.
        }

        private void txtSightingCity_TextChanged(object sender, EventArgs e)
        {
            btnFinishTagSighting.Enabled = hasEnoughInfo();
        }

        private void btnSightingGeocache_Click(object sender, EventArgs e)
        {

        }
    }
}
