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
            btnFinishTagSighting.Enabled = hasEnoughInfo();
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
            btnFinishTagSighting.Enabled = hasEnoughInfo();
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
            btnFinishTagSighting.Enabled = hasEnoughInfo();
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
            btnFinishTagSighting.Enabled = hasEnoughInfo();
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
            btnFinishTagSighting.Enabled = hasEnoughInfo();
        }

        private void cmbSightingStateProv_SelectedIndexChanged(object sender, EventArgs e)
        {
            // TODO Check if city, temperature, and temperature system are entered. (possibly also that tab index is 1).
            btnFinishTagSighting.Enabled = hasEnoughInfo();
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
            if (chkNewTag.Checked && txtSightingSpecies.Text.Trim().Length == 0)
                return false;
            if (txtSightingTagID.Text.Length == 0)
                return false;
            if (tbcLocationPicker.SelectedIndex == 0)
            {
                if (updLatitude.Value != (decimal) 0.0)
                {
                    if (!rdoNorth.Checked && !rdoSouth.Checked)
                        return false;
                }
                if (updLongitude.Value == (decimal) 0.0) // No need to check for E/W button.
                    return rdoCelcius.Checked || rdoFahrenheit.Checked;
                if (!rdoEast.Checked && !rdoWest.Checked)
                    return false;
            }
            else
            {
                if (txtSightingCity.Text.Trim().Length == 0)
                    return false;
                if (cmbSightingCountry.SelectedIndex == -1)
                    return false;
                if (cmbSightingStateProv.SelectedIndex == -1)
                    return false;
            }
            return rdoCelcius.Checked || rdoFahrenheit.Checked;
        }

        private void txtSightingCity_TextChanged(object sender, EventArgs e)
        {
            btnFinishTagSighting.Enabled = hasEnoughInfo();
        }

        private void btnSightingGeocache_Click(object sender, EventArgs e)
        {

        }

        private void frmSightings_Load(object sender, EventArgs e)
        {
            calSightingDate.MaxDate = DateTime.Today;
            cmbSightingCountry.DataSource = Enum.GetValues(typeof (Country));
        }

        private void txtSightingSpecies_TextChanged(object sender, EventArgs e)
        {
            btnFinishTagSighting.Enabled = hasEnoughInfo();
        }

        private void rdoNorth_CheckedChanged(object sender, EventArgs e)
        {
            btnFinishTagSighting.Enabled = hasEnoughInfo();
        }

        private void rdoEast_CheckedChanged(object sender, EventArgs e)
        {
            btnFinishTagSighting.Enabled = hasEnoughInfo();
        }

        private void rdoFahrenheit_CheckedChanged(object sender, EventArgs e)
        {
            btnFinishTagSighting.Enabled = hasEnoughInfo();
        }

        private void rdoSouth_CheckedChanged(object sender, EventArgs e)
        {
            btnFinishTagSighting.Enabled = hasEnoughInfo();
        }

        private void rdoWest_CheckedChanged(object sender, EventArgs e)
        {
            btnFinishTagSighting.Enabled = hasEnoughInfo();
        }

        private void rdoCelcius_CheckedChanged(object sender, EventArgs e)
        {
            btnFinishTagSighting.Enabled = hasEnoughInfo();
        }

        private void tbcLocationPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnFinishTagSighting.Enabled = hasEnoughInfo();
        }
    }
}
