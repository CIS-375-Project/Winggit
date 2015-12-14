using System;
using System.Media;
using System.Windows.Forms;
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
            int reportTypeIndex = tbcReportType.SelectedIndex;
            switch ((ReportType) reportTypeIndex)
            {
                case ReportType.Tags:
                    // TODO If Date selected, find tags only on that date.
                    if (hasDateChanged)
                    {
                        
                    }
                    // TODO if location info provided, find tags at given location.

                    break;
                case ReportType.Sightings:
                    // TODO If Date selected, find sightings only on that date.

                    if (hasDateChanged)
                    {
                        
                    }
                    // TODO if location info provided, find sightings at given location.
                    break;
                case ReportType.Routes:
                    // TODO Check if Tag ID is registered
                    bool isRegistered = true;
                    if (isRegistered) // TODO replace
                    {
                        // TODO load sightings
                    }
                    else
                    {
                        MessageBox.Show(@"Tag not registered.", @"Invalid Tag", MessageBoxButtons.OK);
                    }
                    break;
                case ReportType.Peaks:
                    break;
                case ReportType.Heatmap:
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
                case ReportType.Heatmap:
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
