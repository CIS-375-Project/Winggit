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
    }
}
