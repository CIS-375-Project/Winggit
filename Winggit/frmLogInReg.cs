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
