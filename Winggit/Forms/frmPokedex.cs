using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winggit.Forms
{
    public partial class frmPokedex : Form
    {
        public frmPokedex()
        {
            InitializeComponent();
        }

        private void btnCancelPokedex_Click(object sender, EventArgs e)
        {
            SystemSounds.Asterisk.Play();
            if (MessageBox.Show(@"About to return to main menu. Proceed?", @"Leave Pokédex?", MessageBoxButtons.YesNo) ==
                DialogResult.Yes)
            {
                Close();
            }
        }

        private void frmPokedex_Load(object sender, EventArgs e)
        {
            //TODO Load rankings
        }

        private void btnRefreshRankings_Click(object sender, EventArgs e)
        {
            dgdTaggerRankings.ClearSelection();
            //TODO Reload rankings
        }
    }
}
