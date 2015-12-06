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
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void btnCancelReg_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {

        }

        private void txtRegPhoneNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRegPhoneNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txtRegName_TextChanged(object sender, EventArgs e)
        {
            if (txtRegCity.Text.Length > 0 && txtRegPhoneNum.Text.Length == 10 && txtRegHouseNumStreet.Text.Length > 0
                && cmbRegCountry.SelectedIndex > -1 && cmbRegStateProv.SelectedIndex > -1)
                btnRegister.Enabled = true;
            else
                btnRegister.Enabled = false;
        }

        private void txtRegHouseNumStreet_TextChanged(object sender, EventArgs e)
        {
            if (txtRegCity.Text.Length > 0 && txtRegPhoneNum.Text.Length == 10 && txtRegName.Text.Length > 0
                && cmbRegCountry.SelectedIndex > -1 && cmbRegStateProv.SelectedIndex > -1)
                btnRegister.Enabled = true;
            else
                btnRegister.Enabled = false;
        }

        private void txtRegCity_TextChanged(object sender, EventArgs e)
        {
            if (txtRegHouseNumStreet.Text.Length > 0 && txtRegPhoneNum.Text.Length == 10 && txtRegName.Text.Length > 0
               && cmbRegCountry.SelectedIndex > -1 && cmbRegStateProv.SelectedIndex > -1)
                btnRegister.Enabled = true;
            else
                btnRegister.Enabled = false;
        }

        private void cmbRegStateProv_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbRegCountry_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
