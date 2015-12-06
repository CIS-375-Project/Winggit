using System;
using System.Windows.Forms;

namespace Winggit.Forms
{
    public partial class frmLogInReg : Form
    {
        public frmLogInReg()
        {
            InitializeComponent();
        }

        private void btnGoToLogIn_Click(object sender, EventArgs e)
        {
            new frmLogIn().Show();
        }

        private void btnGoToRegister_Click(object sender, EventArgs e)
        {
            new frmRegister().Show();
        }
    }
}
