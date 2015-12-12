using System;
using System.Media;
using System.Windows.Forms;
using Winggit.Enums;
using System.Collections;
using Winggit.Controls;
using Winggit.Entities;
using System.Data;

namespace Winggit.Forms
{
    public partial class frmSightings : Form
    {
        private bool isButterflyLoaded;
        private int loadedID;
        public frmSightings()
        {
            InitializeComponent();
            isButterflyLoaded = false;
            loadedID = 0;
        }

        private void btnCancelSightings_Click(object sender, EventArgs e)
        {
        }

        private void txtTagID_TextChanged(object sender, EventArgs e)
        {
            btnLoadInfo.Enabled = txtTagID.Text.Length > 0;
            btnFinishTagSighting.Enabled = btnLoadInfo.Text == @"Go Back" && hasEnoughInfo();
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
            btnLoadInfo.Enabled = !chkNewTag.Checked;
            txtSightingSpecies.Enabled = chkNewTag.Checked;
            btnFinishTagSighting.Enabled = btnLoadInfo.Text == @"Go Back" && hasEnoughInfo();
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
            if (cmbSightingCountry.SelectedIndex > 0)
            {
                cmbSightingStateProv.Enabled = true;
                cmbSightingStateProv.DataSource = Enum.GetValues(cmbSightingCountry.SelectedIndex == 1 ? typeof (State) : typeof (Province));
            }
            else
            {
                cmbSightingStateProv.Enabled = false;
                cmbSightingStateProv.SelectedIndex = -1;
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
            Hashtable oHash;
            string sql;
            if (chkNewTag.Checked)
            {
                oHash = new Hashtable();
                oHash.Add("@WingSpan", updWingspan.Value);
                oHash.Add("@Species", txtSightingSpecies.Text.Trim());
                if(rdoMale.Checked)
                {
                    oHash.Add("@Gender", "Male");
                }
                else if (rdoFemale.Checked)
                {
                    oHash.Add("@Gender", "Female");
                }
                else
                {
                    oHash.Add("@Gender", "Unknown");
                }
                oHash.Add("@TagNum", txtTagID.Text);
                sql = "INSERT INTO Butterflies OUTPUT inserted.* VALUES(@WingSpan,@Species,@Gender,0,@TagNum)";
                using (DataSet oDataSet = DBFunctions.GetDataSet(sql, oHash))
                {
                    oHash = new Hashtable();
                    sql = "INSERT INTO Tags VALUES (@Date,@City,@State,@Country,@Temp,@WingerNum,1,@Long,@Lat,@ID)";
                    oHash.Add("@Date", calSightingDate.SelectionStart);
                    if(!string.IsNullOrEmpty(txtSightingCity.Text))
                    {
                        oHash.Add("@City", txtSightingCity.Text.Trim());
                        oHash.Add("@State", cmbSightingStateProv.SelectedText);
                        oHash.Add("@Country", cmbSightingCountry.SelectedText);
                    }
                    else
                    {
                        oHash.Add("@City", null);
                        oHash.Add("@State", null);
                        oHash.Add("@Country", null);
                    }
                    oHash.Add("@Temp", updTemperature.Value);
                    oHash.Add("@WingerNum", Winger.currentWinger.WingerNum);
                    if (updLatitude.Value > 0 || updLongitude.Value > 0)
                    {
                        oHash.Add("@Long", updLongitude.Value);
                        oHash.Add("@Lat", updLatitude.Value);
                    }
                    else
                    {
                        oHash.Add("@Long", null);
                        oHash.Add("@Lat", null);
                    }
                    oHash.Add("@ID", oDataSet.Tables[0].Rows[0]["ButterflyID"]);
                    DBFunctions.RunQuery(sql, oHash);
                    MessageBox.Show(@"Registered under Tag ID #" + txtTagID.Text, @"Butterfly tagged!", MessageBoxButtons.OK);
                    return;
                }
            }
            else
            {
                if (CheckButterfly(int.Parse(txtTagID.Text)))
                {
                    oHash = new Hashtable();
                    sql = "INSERT INTO Tags VALUES (@Date,@City,@State,@Country,@Temp,@WingerNum,0,@Long,@Lat,@ID)";
                    oHash.Add("@Date", calSightingDate.SelectionStart);
                    if (!string.IsNullOrEmpty(txtSightingCity.Text))
                    {
                        oHash.Add("@City", txtSightingCity.Text.Trim());
                        oHash.Add("@State", cmbSightingStateProv.SelectedText);
                        oHash.Add("@Country", cmbSightingCountry.SelectedText);
                    }
                    else
                    {
                        oHash.Add("@City", null);
                        oHash.Add("@State", null);
                        oHash.Add("@Country", null);
                    }
                    oHash.Add("@Temp", updTemperature.Value);
                    oHash.Add("@WingerNum", Winger.currentWinger.WingerNum);
                    if (updLatitude.Value > 0 || updLongitude.Value > 0)
                    {
                        oHash.Add("@Long", updLongitude.Value);
                        oHash.Add("@Lat", updLatitude.Value);
            }
            else
            {
                        oHash.Add("@Long", null);
                        oHash.Add("@Lat", null);
                    }
                    oHash.Add("@ID", Butterfly.currentButterfly.ButterflyID);
                    DBFunctions.RunQuery(sql, oHash);
                    MessageBox.Show(@"Registered under Tag ID #" + txtTagID.Text, @"Butterfly tagged!", MessageBoxButtons.OK);
                }
            }
        }

        private bool hasEnoughInfo()
        {
            if (chkNewTag.Checked && txtSightingSpecies.Text.Trim().Length == 0)
                return false;
            if (txtTagID.Text.Length == 0)
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
                if (cmbSightingCountry.SelectedIndex <= 0)
                    return false;
                if (cmbSightingStateProv.SelectedIndex <= 0)
                    return false;
            }
            return rdoCelcius.Checked || rdoFahrenheit.Checked;
        }

        private void txtSightingCity_TextChanged(object sender, EventArgs e)
        {
            btnFinishTagSighting.Enabled = hasEnoughInfo();
        }

        private void btnSightingGeocode_Click(object sender, EventArgs e)
        {
            if (tbcLocationPicker.SelectedIndex == 0)
            {
                // TODO try to load city/state/country
            }
            else
            {
                // TODO try to load lat/long
            }
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

        private void frmSightings_FormClosing(object sender, FormClosingEventArgs e)
        {
            SystemSounds.Asterisk.Play();
            if (MessageBox.Show(@"Any info you entered will be lost.", @"Are you sure?", MessageBoxButtons.YesNo) ==
                DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnLoadInfo_Click(object sender, EventArgs e)
        {
            if (!isButterflyLoaded)
            {
                if (!CheckButterfly(int.Parse(txtTagID.Text)))
                    return;
                txtSightingSpecies.Text = Butterfly.currentButterfly.Species;
                txtSightingSpecies.Enabled = false;
                if (Butterfly.currentButterfly.Gender == "Male")
                {
                    rdoMale.Checked = true;
                    grpGender.Enabled = false;
                }
                else if (Butterfly.currentButterfly.Gender == "Female")
                {
                    rdoFemale.Checked = true;
                    grpGender.Enabled = false;
                }
                updWingspan.Value = Butterfly.currentButterfly.Wingspan;
                btnLoadInfo.Text = @"Go Back";
                isButterflyLoaded = true;
                chkNewTag.Enabled = false;
                txtTagID.Enabled = false;
            }
            else
            {
                grpGender.Enabled = true;
                rdoUnknown.Checked = true;
                updWingspan.Value = 0;
                btnLoadInfo.Text = @"Load Info";
                isButterflyLoaded = false;
                txtTagID.Text = "";
                txtSightingSpecies.Text = "";
                chkNewTag.Enabled = true;
                txtTagID.Enabled = true;
            }
        }

        private bool CheckButterfly(int id)
        {
            Hashtable oHash = new Hashtable();
            oHash.Add("@TagNum", id);
            string sql = "SELECT * FROM Butterflies WHERE Tracker_Num = @TagNum";
            using (DataSet oDataSet = DBFunctions.GetDataSet(sql, oHash))
            {
                if (oDataSet.Tables.Count == 0 || oDataSet.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show(@"No Butterflies found with that Tag ID #. But you can add it as a new one.",
                        @"Butterfly Not Found");
                    Butterfly.currentButterfly = null;
                    return false;
                }
                Butterfly.currentButterfly = new Butterfly(oDataSet.Tables[0].Rows[0]);
                return true;
            }
        }
    }
}
