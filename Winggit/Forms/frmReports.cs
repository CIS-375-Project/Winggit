using System;
using System.Media;
using System.Windows.Forms;
using Winggit.Enums;

namespace Winggit.Forms
{
    public partial class frmReports : Form
    {
        public frmReports()
        {
            InitializeComponent();
        }

        private void btnCancelReports_Click(object sender, EventArgs e)
        {
        }

        private void frmReports_Load(object sender, EventArgs e)
        {
            cmbReportType.DataSource = Enum.GetValues(typeof (ReportType));
            
        }

        private void btnGetReport_Click(object sender, EventArgs e)
        {
            switch ((ReportType) cmbReportType.SelectedIndex)
            {
                case ReportType.Tags:
                    break;
                case ReportType.Sightings:
                    break;
                case ReportType.Routes:
                    break;
                case ReportType.Peaks:
                    break;
                case ReportType.Heatmap:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private void frmReports_FormClosing(object sender, FormClosingEventArgs e)
        {
            SystemSounds.Asterisk.Play();
            if (MessageBox.Show(@"Any info you entered will be lost.", @"Are you sure?", MessageBoxButtons.YesNo) ==
                DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void cmbReportType_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnGetReport.Enabled = cmbReportType.SelectedIndex > 0;
        }
    }
}
