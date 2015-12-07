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

        }

        private void txtMigrationTagID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
