using System;
using System.Media;
using System.Windows.Forms;

namespace Winggit.Forms
{
    public partial class frmMigration : Form
    {
        public frmMigration()
        {
            InitializeComponent();
        }

        private void btnCancelMigration_Click(object sender, EventArgs e)
        {
            SystemSounds.Asterisk.Play();
            if (MessageBox.Show(@"Any info you entered will be lost.", @"Are you sure?", MessageBoxButtons.YesNo) ==
                DialogResult.Yes)
            {
                Close();
            }
        }

        private void txtMigrationTagID_TextChanged(object sender, EventArgs e)
        {
            btnSeeMigration.Enabled = txtMigrationTagID.Text.Length > 0;
        }

        private void txtMigrationTagID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnSeeMigration_Click(object sender, EventArgs e)
        {
            // TODO Check if Tag ID exists.
            // TODO If ID exists, load sightings into table.
            // TODO Else, send rejection message to user.
        }
    }
}
