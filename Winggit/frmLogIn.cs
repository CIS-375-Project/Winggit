using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winggit
{
    public partial class frmLogIn : Form
    {
        public frmLogIn()
        {
            InitializeComponent();
        }

        private void btnCancelLogIn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            // TODO verify that tagger ID exists.
        }

        private void txtLogInID_TextChanged(object sender, EventArgs e)
        {
            btnLogIn.Enabled = txtLogInID.Text.Length > 0;
        }

        private void txtLogInID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
    }
}
