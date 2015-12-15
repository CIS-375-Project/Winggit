using System;
using System.Data;
using System.Collections;
using System.Media;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Winggit.Controls;
using Winggit.Enums;

namespace Winggit.Forms
{
    public partial class frmReports : Form
    {
        private bool hasDateChanged;
        public frmReports()
        {
            hasDateChanged = false;
            InitializeComponent();
        }

        private void btnCancelReports_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmReports_Load(object sender, EventArgs e)
        {
            calSightingsRptDate.MaxDate = DateTime.Today;
            calTagsRptDate.MaxDate = DateTime.Today;
            cmbTagsRptCountry.DataSource = Enum.GetValues(typeof (Country));
            //cmbTagsRptCountry.SelectedIndex = 0; Might not be needed
            cmbSightRptCountry.DataSource = Enum.GetValues(typeof (Country));

        }

        private void btnGetReport_Click(object sender, EventArgs e)
        {

            Hashtable oHash;
            string sql;
            int reportTypeIndex = tbcReportType.SelectedIndex;
            switch ((ReportType) reportTypeIndex)
            {
                case ReportType.Tags:
                    
                    if (hasDateChanged && cmbTagsRptCountry.SelectedIndex == 0 && string.IsNullOrWhiteSpace(txtTagRptCity.Text))
                    {
                        oHash = new Hashtable();
                        oHash.Add("@Date", calTagsRptDate.SelectionStart);
                        sql = "SELECT * FROM Tags WHERE Date = @Date AND Type_of_Reporting = 1";
                        
                        using (DataSet oDataSet = DBFunctions.GetDataSet(sql, oHash))
                        {
                            dgdReportTable.DataSource = oDataSet.Tables[0];
                            dgdReportTable.AllowUserToAddRows = false;
                            dgdReportTable.ReadOnly = true;
                    }

                    }

                    if (cmbTagsRptCountry.SelectedIndex > 0 && !hasDateChanged)
                    {
                        if (cmbTagRptStateProv.SelectedIndex > 0)
                        {
                            if (!string.IsNullOrWhiteSpace(txtTagRptCity.Text))
                            {
                                oHash = new Hashtable();
                                oHash.Add("@City", txtTagRptCity.Text);
                                oHash.Add("@State_Providence", cmbTagRptStateProv.SelectedItem.ToString());
                                oHash.Add("@Country", cmbTagsRptCountry.SelectedItem.ToString());

                                sql =
                                    "SELECT * FROM Tags WHERE City = @City AND State_Providence = @State_Providence AND Country = @Country AND Type_of_Reporting = 1";

                                using (DataSet oDataSet = DBFunctions.GetDataSet(sql, oHash))
                                {
                                    dgdReportTable.DataSource = oDataSet.Tables[0];
                                    dgdReportTable.AllowUserToAddRows = false;
                                    dgdReportTable.ReadOnly = true;
                                }

                            }
                            else
                            {
                                oHash = new Hashtable();
                                oHash.Add("@State_Providence", cmbTagRptStateProv.SelectedItem.ToString());
                                oHash.Add("@Country", cmbTagsRptCountry.SelectedItem.ToString());

                                sql =
                                    "SELECT * FROM Tags WHERE State_Providence = @State_Providence AND Country = @Country AND Type_of_Reporting = 1";

                                using (DataSet oDataSet = DBFunctions.GetDataSet(sql, oHash))
                                {
                                    dgdReportTable.DataSource = oDataSet.Tables[0];
                                    dgdReportTable.AllowUserToAddRows = false;
                                    dgdReportTable.ReadOnly = true;
                                }
                            }
                        }
                    }
                    else if(cmbTagsRptCountry.SelectedIndex > 0 && hasDateChanged)
                    {
                        if (cmbTagRptStateProv.SelectedIndex > 0)
                        {
                            if (!string.IsNullOrWhiteSpace(txtTagRptCity.Text))
                            {
                                oHash = new Hashtable();
                                oHash.Add("@Date", calTagsRptDate.SelectionStart);
                                oHash.Add("@City", txtTagRptCity.Text);
                                oHash.Add("@State_Providence", cmbTagRptStateProv.SelectedItem.ToString());
                                oHash.Add("@Country", cmbTagsRptCountry.SelectedItem.ToString());

                                sql =
                                    "SELECT * FROM Tags WHERE Date = @Date AND City = @City AND State_Providence = @State_Providence AND Country = @Country AND Type_of_Reporting = 1";

                                using (DataSet oDataSet = DBFunctions.GetDataSet(sql, oHash))
                                {
                                    dgdReportTable.DataSource = oDataSet.Tables[0];
                                    dgdReportTable.AllowUserToAddRows = false;
                                    dgdReportTable.ReadOnly = true;
                                }
                            }
                            else
                            {
                                oHash = new Hashtable();
                                oHash.Add("@Date", calTagsRptDate.SelectionStart);
                                oHash.Add("@State_Providence", cmbTagRptStateProv.SelectedItem.ToString());
                                oHash.Add("@Country", cmbTagsRptCountry.SelectedItem.ToString());

                                sql =
                                    "SELECT * FROM Tags WHERE Date = @Date AND State_Providence = @State_Providence AND Country = @Country AND Type_of_Reporting = 1";

                                using (DataSet oDataSet = DBFunctions.GetDataSet(sql, oHash))
                                {
                                    dgdReportTable.DataSource = oDataSet.Tables[0];
                                    dgdReportTable.AllowUserToAddRows = false;
                                    dgdReportTable.ReadOnly = true;
                                }
                            }
                        }
                    }
                    break;
                case ReportType.Sightings:
                    
                    if (hasDateChanged && cmbSightRptCountry.SelectedIndex == 0 && string.IsNullOrWhiteSpace(txtSightRptCity.Text))
                    {
                        oHash = new Hashtable();
                        oHash.Add("@Date", calSightingsRptDate.SelectionStart);
                        sql = "SELECT * FROM Tags WHERE Date = @Date AND Type_of_Reporting = 0";

                        using (DataSet oDataSet = DBFunctions.GetDataSet(sql, oHash))
                        {
                            dgdReportTable.DataSource = oDataSet.Tables[0];
                            dgdReportTable.AllowUserToAddRows = false;
                            dgdReportTable.ReadOnly = true;
                        }

                    }

                    if (cmbSightRptCountry.SelectedIndex > 0 && !hasDateChanged)
                    {
                        if (cmbSightRptStateProv.SelectedIndex > 0)
                        {
                            if (!string.IsNullOrWhiteSpace(txtSightRptCity.Text))
                            {
                                oHash = new Hashtable();
                                oHash.Add("@City", txtSightRptCity.Text);
                                oHash.Add("@State_Providence", cmbSightRptStateProv.SelectedItem.ToString());
                                oHash.Add("@Country", cmbSightRptCountry.SelectedItem.ToString());

                                sql =
                                    "SELECT * FROM Tags WHERE City = @City AND State_Providence = @State_Providence AND Country = @Country AND Type_of_Reporting = 0";

                                using (DataSet oDataSet = DBFunctions.GetDataSet(sql, oHash))
                                {
                                    dgdReportTable.DataSource = oDataSet.Tables[0];
                                    dgdReportTable.AllowUserToAddRows = false;
                                    dgdReportTable.ReadOnly = true;
                                }

                            }
                            else
                            {
                                oHash = new Hashtable();
                                oHash.Add("@State_Providence", cmbSightRptStateProv.SelectedItem.ToString());
                                oHash.Add("@Country", cmbSightRptCountry.SelectedItem.ToString());

                                sql =
                                    "SELECT * FROM Tags WHERE State_Providence = @State_Providence AND Country = @Country AND Type_of_Reporting = 0";

                                using (DataSet oDataSet = DBFunctions.GetDataSet(sql, oHash))
                                {
                                    dgdReportTable.DataSource = oDataSet.Tables[0];
                                    dgdReportTable.AllowUserToAddRows = false;
                                    dgdReportTable.ReadOnly = true;
                                }
                            }
                        }
                    }
                    else if (cmbSightRptCountry.SelectedIndex > 0 && hasDateChanged)
                    {
                        if (cmbSightRptStateProv.SelectedIndex > 0)
                        {
                            if (!string.IsNullOrWhiteSpace(txtSightRptCity.Text))
                            {
                                oHash = new Hashtable();
                                oHash.Add("@Date", calSightingsRptDate.SelectionStart);
                                oHash.Add("@City", txtSightRptCity.Text);
                                oHash.Add("@State_Providence", cmbSightRptStateProv.SelectedItem.ToString());
                                oHash.Add("@Country", cmbSightRptCountry.SelectedItem.ToString());

                                sql =
                                    "SELECT * FROM Tags WHERE Date = @Date AND City = @City AND State_Providence = @State_Providence AND Country = @Country AND Type_of_Reporting = 0";

                                using (DataSet oDataSet = DBFunctions.GetDataSet(sql, oHash))
                                {
                                    dgdReportTable.DataSource = oDataSet.Tables[0];
                                    dgdReportTable.AllowUserToAddRows = false;
                                    dgdReportTable.ReadOnly = true;
                                }
                            }
                            else
                            {
                                oHash = new Hashtable();
                                oHash.Add("@Date", calSightingsRptDate.SelectionStart);
                                oHash.Add("@State_Providence", cmbSightRptStateProv.SelectedItem.ToString());
                                oHash.Add("@Country", cmbSightRptCountry.SelectedItem.ToString());

                                sql =
                                    "SELECT * FROM Tags WHERE Date = @Date AND State_Providence = @State_Providence AND Country = @Country AND Type_of_Reporting = 0";

                                using (DataSet oDataSet = DBFunctions.GetDataSet(sql, oHash))
                    {
                                    dgdReportTable.DataSource = oDataSet.Tables[0];
                                    dgdReportTable.AllowUserToAddRows = false;
                                    dgdReportTable.ReadOnly = true;
                                }
                            }
                        }
                    }
                    break;
                case ReportType.Routes:
                    
                    oHash = new Hashtable();
                    oHash.Add("@Tracker_Num", txtReportRouteID.Text);

                    sql = "SELECT T.Date, T.City, T.State_Providence, T.Country, T.Latitude, T.Longitude, T.ButterflyID FROM Tags AS T JOIN Butterflies AS B ON T.ButterflyID = B.ButterflyID WHERE B.Tracker_Num = @Tracker_Num ORDER BY T.Date";

                    using (DataSet oDataSet = DBFunctions.GetDataSet(sql, oHash))
                    {
                        if (oDataSet.Tables.Count == 0 || oDataSet.Tables[0].Rows.Count == 0)
                    {
                            MessageBox.Show("That tag does not exist!", "Non-existent tag", MessageBoxButtons.OK);
                            return;
                    }
                    else
                    {
                            dgdReportTable.DataSource = oDataSet.Tables[0];
                            dgdReportTable.AllowUserToAddRows = false;
                            dgdReportTable.ReadOnly = true;
                        }

                    }

                    break;
                case ReportType.Peaks:
                    break;
                case ReportType.Graph:
                    break;
            }
        }

        private void frmReports_FormClosing(object sender, FormClosingEventArgs e)
        {
            SystemSounds.Asterisk.Play();
            if (MessageBox.Show(@"Any info you entered will be lost.", @"Are you sure?", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void txtReportRouteID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cmbTagsRptCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTagsRptCountry.SelectedIndex > 0)
            {
                cmbTagRptStateProv.Enabled = true;
                cmbTagRptStateProv.DataSource = Enum.GetValues(cmbTagsRptCountry.SelectedIndex == 1 ? typeof(State) : typeof(Province));
            }
            else
            {
                cmbTagRptStateProv.Enabled = false;
                cmbTagRptStateProv.SelectedIndex = -1;
            }
            btnGetReport.Enabled = hasDateChanged || cmbTagsRptCountry.SelectedIndex > 0 || txtTagRptCity.Text.Trim().Length > 0;
        }

        private void txtTagRptCity_TextChanged(object sender, EventArgs e)
        {
            if (txtTagRptCity.Text.Trim().Length == 0)
            {
                txtTagRptCity.Text = "";
            }
            btnGetReport.Enabled = hasDateChanged || txtTagRptCity.Text.Length > 0 || cmbTagsRptCountry.SelectedIndex > 0;
        }

        private void txtSightRptCity_TextChanged(object sender, EventArgs e)
        {
            if (txtSightRptCity.Text.Trim().Length == 0)
            {
                txtSightRptCity.Text = "";
            }
            btnGetReport.Enabled = hasDateChanged || txtSightRptCity.Text.Length > 0 || cmbSightRptCountry.SelectedIndex > 0;
        }

        private void cmbSightRptCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSightRptCountry.SelectedIndex > 0)
            {
                cmbSightRptStateProv.Enabled = true;
                cmbSightRptStateProv.DataSource = Enum.GetValues(cmbSightRptCountry.SelectedIndex == 1 ? typeof(State) : typeof(Province));
            }
            else
            {
                cmbSightRptStateProv.Enabled = false;
                cmbSightRptStateProv.SelectedIndex = -1;
            }
            btnGetReport.Enabled = hasDateChanged || cmbSightRptCountry.SelectedIndex > 0 || txtSightRptCity.Text.Trim().Length > 0;
        }

        private void txtPeaksID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPeaksID_TextChanged(object sender, EventArgs e)
        {
            btnGetReport.Enabled = hasDateChanged || txtPeaksID.Text.Length > 0;
        }

        private void txtReportRouteID_TextChanged(object sender, EventArgs e)
        {
            btnGetReport.Enabled = hasDateChanged || txtReportRouteID.Text.Length > 0;
        }

        private void tbcReportType_SelectedIndexChanged(object sender, EventArgs e)
        {
            hasDateChanged = false;
            switch ((ReportType) tbcReportType.SelectedIndex)
            {
                case ReportType.Tags:
                    btnGetReport.Enabled = cmbTagsRptCountry.SelectedIndex > 0 || txtTagRptCity.Text.Trim().Length > 0;
                    break;
                case ReportType.Sightings:
                    btnGetReport.Enabled = cmbSightRptCountry.SelectedIndex > 0 || txtSightRptCity.Text.Trim().Length > 0;
                    break;
                case ReportType.Routes:
                    btnGetReport.Enabled = txtReportRouteID.Text.Length > 0;
                    break;
                case ReportType.Peaks:
                    btnGetReport.Enabled = txtPeaksID.Text.Length > 0;
                    break;
                case ReportType.Graph:
                    cTags.Series["Tags"].XValueType = ChartValueType.DateTime;
                    cTags.Series["Sightings"].XValueType = ChartValueType.DateTime;
                    cTags.Series["All"].XValueType = ChartValueType.DateTime;
                    Hashtable oHash = new Hashtable();
                    string sql = "SELECT COUNT(*) as 'Count', Date, Type_of_Reporting FROM Tags GROUP BY Date, Type_of_Reporting ORDER BY Date";
                    using (DataSet oDataSet = DBFunctions.GetDataSet(sql, oHash))
                    {
                        if (oDataSet.Tables.Count == 0 || oDataSet.Tables[0].Rows.Count == 0)
                        {
                            break;
                        }
                        foreach (DataRow oRow in oDataSet.Tables[0].Rows)
                        {
                            if (bool.Parse(oRow["Type_Of_Reporting"].ToString()))
                            {
                                DateTime x = DateTime.Parse(oRow["Date"].ToString());
                                cTags.Series["Tags"].Points.AddXY(x.ToOADate(), int.Parse(oRow["Count"].ToString()));
                            }
                            else
                            {
                                DateTime x = DateTime.Parse(oRow["Date"].ToString());
                                cTags.Series["Sightings"].Points.AddXY(x.ToOADate(), int.Parse(oRow["Count"].ToString()));
                            }
                        }
                        cTags.Series["Tags"].ChartType = SeriesChartType.FastLine;
                        cTags.Series["Sightings"].ChartType = SeriesChartType.FastLine;
                    }
                    sql = "SELECT COUNT(*) as 'Count', Date FROM Tags GROUP BY Date ORDER BY Date";
                    using (DataSet oDataSet = DBFunctions.GetDataSet(sql, oHash))
                    {
                        if (oDataSet.Tables.Count == 0 || oDataSet.Tables[0].Rows.Count == 0)
                        {
                            break;
                        }
                        foreach (DataRow oRow in oDataSet.Tables[0].Rows)
                        {
                            DateTime x = DateTime.Parse(oRow["Date"].ToString());
                            cTags.Series["All"].Points.AddXY(x.ToOADate(), int.Parse(oRow["Count"].ToString()));
                        }
                    }
                    cTags.Series["All"].ChartType = SeriesChartType.FastLine;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private void calTagsRptDate_DateSelected(object sender, DateRangeEventArgs e)
        {
            hasDateChanged = true;
            btnGetReport.Enabled = true;
        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            // TODO Determine if we can output to file. If not, display messagebox.
        }

        private void calSightingsRptDate_DateSelected(object sender, DateRangeEventArgs e)
        {
            hasDateChanged = true;
            btnGetReport.Enabled = true;
        }
    }
}
