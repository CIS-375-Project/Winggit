using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Windows.Forms;

namespace Winggit
{
    public partial class frmTaggerSearch : Form
    {
        public frmTaggerSearch()
        {
            InitializeComponent();
        }

        private void btnCancelSearch_Click(object sender, EventArgs e)
        {
            SystemSounds.Asterisk.Play();
            if (MessageBox.Show(@"Are You Sure?", @"Any info you entered will be lost.", MessageBoxButtons.YesNo) ==
                DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
