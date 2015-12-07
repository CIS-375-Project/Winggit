using System;
using System.Media;
using System.Windows.Forms;

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

        private void btnGoToTagging_Click(object sender, EventArgs e)
        {
            new frmTagging().Show();
        }
    }
}
