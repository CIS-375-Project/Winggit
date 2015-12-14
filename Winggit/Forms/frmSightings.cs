﻿using System;
using System.Media;
using System.Windows.Forms;
using Winggit.Enums;
using System.Collections;
using Winggit.Controls;
using Winggit.Entities;
using System.Data;
using System.Net;
using System.IO;
using System.Text;

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

        private void txtTagID_TextChanged(object sender, EventArgs e)
        {
            btnLoadInfo.Enabled = txtTagID.Text.Length > 0;
            btnFinishTagSighting.Enabled = btnLoadInfo.Text == @"Go Back" && HasEnoughInfo();
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
            btnFinishTagSighting.Enabled = btnLoadInfo.Text == @"Go Back" && HasEnoughInfo();
        }

        private void updLatitude_ValueChanged(object sender, EventArgs e)
        {
            btnFinishTagSighting.Enabled = HasEnoughInfo();
        }

        private void updLongitude_ValueChanged(object sender, EventArgs e)
        {
            btnFinishTagSighting.Enabled = HasEnoughInfo();
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
            btnFinishTagSighting.Enabled = HasEnoughInfo();
        }

        private void cmbSightingStateProv_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnFinishTagSighting.Enabled = HasEnoughInfo();
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
                    sql = "INSERT INTO Tags VALUES (@Date,";
                    oHash.Add("@Date", calSightingDate.SelectionStart);
                    if(!string.IsNullOrEmpty(txtSightingCity.Text))
                    {
                        oHash.Add("@City", txtSightingCity.Text.Trim());
                        oHash.Add("@State", cmbSightingStateProv.SelectedItem.ToString());
                        oHash.Add("@Country", cmbSightingCountry.SelectedItem.ToString());
                        sql += "@City,@State,Country,";
                    }
                    else
                    {
                        sql += "NULL,NULL,NULL,";
                    }
                    oHash.Add("@Temp", updTemperature.Value);
                    oHash.Add("@WingerNum", Winger.currentWinger.WingerNum);
                    sql += "@Temp,@WingerNum,1,";
                    if (updLatitude.Value > 0 || updLongitude.Value > 0)
                    {
                        oHash.Add("@Long", updLongitude.Value);
                        oHash.Add("@Lat", updLatitude.Value);
                        sql += "@Long,@Lat,";
                    }
                    else
                    {
                        sql += "NULL,NULL,";
                    }
                    oHash.Add("@ID", oDataSet.Tables[0].Rows[0]["ButterflyID"]);
                    sql += "@ID)";
                    DBFunctions.RunQuery(sql, oHash);
                    SetCompletionRate();
                    MessageBox.Show(@"Registered under Tag ID #" + txtTagID.Text, @"Butterfly tagged!", MessageBoxButtons.OK);
                }
            }
            else
            {
                if (CheckButterfly(int.Parse(txtTagID.Text)))
                {
                    oHash = new Hashtable();
                    sql = "INSERT INTO Tags VALUES (@Date,";
                    oHash.Add("@Date", calSightingDate.SelectionStart);
                    if (!string.IsNullOrEmpty(txtSightingCity.Text))
                    {
                        oHash.Add("@City", txtSightingCity.Text.Trim());
                        oHash.Add("@State", cmbSightingStateProv.SelectedItem.ToString());
                        oHash.Add("@Country", cmbSightingCountry.SelectedItem.ToString());
                        sql += "@City,@State,@Country,";
                    }
                    else
                    {
                        sql += "NULL,NULL,NULL,";
                    }
                    oHash.Add("@Temp", updTemperature.Value);
                    oHash.Add("@WingerNum", Winger.currentWinger.WingerNum);
                    sql += "@Temp,@WingerNum,0,";
                    if (updLatitude.Value > 0 || updLongitude.Value > 0)
                    {
                        oHash.Add("@Long", updLongitude.Value);
                        oHash.Add("@Lat", updLatitude.Value);
                        sql += "@Long,@Lat,";
                    }
                    else
                    {
                        sql += "NULL,NULL";
                    }                  
                    oHash.Add("@ID", Butterfly.currentButterfly.ButterflyID);
                    sql += "@ID)";
                    DBFunctions.RunQuery(sql, oHash);
                    SetCompletionRate();
                    MessageBox.Show(@"Registered under Tag ID #" + txtTagID.Text, @"Butterfly tagged!", MessageBoxButtons.OK);
                    Close();
                }
            }
        }

        private bool HasEnoughInfo()
        {
            if (chkNewTag.Checked && txtSightingSpecies.Text.Trim().Length == 0)
                return false;
            if (txtTagID.Text.Length == 0)
                return false;
            if (tbcLocationPicker.SelectedIndex != 1)
                return rdoCelcius.Checked || rdoFahrenheit.Checked;
            if (txtSightingCity.Text.Trim().Length == 0)
                return false;
            if (cmbSightingCountry.SelectedIndex <= 0)
                return false;
            if (cmbSightingStateProv.SelectedIndex <= 0)
                return false;
            return rdoCelcius.Checked || rdoFahrenheit.Checked;
        }

        private void txtSightingCity_TextChanged(object sender, EventArgs e)
        {
            btnFinishTagSighting.Enabled = HasEnoughInfo();
        }

        private void btnSightingGeocode_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSightingCity.Text))
            {
                string url = "https://maps.googleapis.com/maps/api/geocode/xml?latlng=" + updLatitude.Value + "," + updLongitude.Value + "&key=AIzaSyDXWy0DPLRt8eYBRMZTMB3l_d4RjvSz7N8";
                WebRequest request = WebRequest.Create(url);
                using (WebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    using (StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8))
                    {
                        using (DataSet oDataSet = new DataSet())
                        {
                            oDataSet.ReadXml(reader);
                            if (oDataSet.Tables[0].Rows[0][0].ToString() != "ZERO_RESULTS")
                            {
                                
                            }
                            string[] location = oDataSet.Tables[1].Rows[1][1].ToString().Split(',');
                            txtSightingCity.Text = location[0];
                            cmbSightingCountry.SelectedIndex = cmbSightingCountry.FindString(location[1]);
                            cmbSightingStateProv.SelectedIndex = cmbSightingStateProv.FindString(location[2]);
                        }
                    }
                }
            }
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
            btnFinishTagSighting.Enabled = HasEnoughInfo();
        }

        private void rdoFahrenheit_CheckedChanged(object sender, EventArgs e)
        {
            btnFinishTagSighting.Enabled = HasEnoughInfo();
        }

        private void rdoCelcius_CheckedChanged(object sender, EventArgs e)
        {
            btnFinishTagSighting.Enabled = HasEnoughInfo();
        }

        private void tbcLocationPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnFinishTagSighting.Enabled = HasEnoughInfo();
        }

        private void frmSightings_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                SystemSounds.Asterisk.Play();
                if (MessageBox.Show(@"Any info you entered will be lost.", @"Are you sure?", MessageBoxButtons.YesNo) ==
                    DialogResult.No)
                {
                    e.Cancel = true;
                }
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

        private void SetCompletionRate()
        {
            float completionPercentage; 
            Hashtable oHash = new Hashtable();
            oHash.Add("@WingerNum", Winger.currentWinger.WingerNum);
            string sql =
                "SELECT COUNT(*) AS 'NumSightings', ButterflyID FROM Tags WHERE WingerNum = @WingerNum GROUP BY ButterflyID";

            using (DataSet oDataSet = DBFunctions.GetDataSet(sql, oHash))
            {
                sql = "SELECT COUNT(*) AS 'NumButterflies' FROM Butterflies";
                oHash = new Hashtable();

                using (DataSet oDataSet2 = DBFunctions.GetDataSet(sql, oHash))
                {
                    int rows1, rows2;
                    rows1 = oDataSet.Tables[0].Rows.Count;
                    rows2 = (int) oDataSet2.Tables[0].Rows[0]["NumButterflies"];

                    //completionPercentage = (oDataSet.Tables[0].Rows.Count/
                                                  //(int)oDataSet2.Tables[0].Rows[0]["NumButterflies"])*100;

                    completionPercentage = ((float)rows1/(float)rows2)*100;
                }
            }

            oHash = new Hashtable();
            oHash.Add("@WingerNum", Winger.currentWinger.WingerNum);
            oHash.Add("@Percent_Complete", completionPercentage);
            sql = "UPDATE Wingers SET Percent_Complete = @Percent_Complete WHERE WingerNum = @WingerNum";

            DBFunctions.RunQuery(sql, oHash);
        }
    }
}
