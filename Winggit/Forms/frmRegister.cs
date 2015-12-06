using System;
using System.Media;
using System.Windows.Forms;
using Winggit.Enums;

namespace Winggit.Forms
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void btnCancelReg_Click(object sender, EventArgs e)
        {
            SystemSounds.Asterisk.Play();
            if (MessageBox.Show(@"Are you sure?", @"Any info you entered will be lost. Proceed?",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {
            cmbRegCountry.DataSource = Enum.GetValues(typeof (Countries));
            btnRegister.Enabled = false;
        }

        private void txtRegPhoneNum_TextChanged(object sender, EventArgs e)
        {
            if (txtRegCity.Text.Length > 0 && txtRegPhoneNum.Text.Length == 10 && txtRegHouseNumStreet.Text.Length > 0
                && cmbRegCountry.SelectedIndex > -1 && cmbRegStateProv.SelectedIndex > -1)
            {
                btnRegister.Enabled = true;
            }
            else
            {
                btnRegister.Enabled = false;
            }
        }

        private void txtRegPhoneNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtRegName_TextChanged(object sender, EventArgs e)
        {
            if (txtRegCity.Text.Length > 0 && txtRegPhoneNum.Text.Length == 10 && txtRegHouseNumStreet.Text.Length > 0
                && cmbRegCountry.SelectedIndex > -1 && cmbRegStateProv.SelectedIndex > -1)
            {
                btnRegister.Enabled = true;
            }
            else
            {
                btnRegister.Enabled = false;
            }
        }

        private void txtRegHouseNumStreet_TextChanged(object sender, EventArgs e)
        {
            if (txtRegCity.Text.Length > 0 && txtRegPhoneNum.Text.Length == 10 && txtRegName.Text.Length > 0
                && cmbRegCountry.SelectedIndex > -1 && cmbRegStateProv.SelectedIndex > -1)
            {
                btnRegister.Enabled = true;
            }
            else
            {
                btnRegister.Enabled = false;
            }
        }

        private void txtRegCity_TextChanged(object sender, EventArgs e)
        {
            if (txtRegHouseNumStreet.Text.Length > 0 && txtRegPhoneNum.Text.Length == 10 && txtRegName.Text.Length > 0
                && cmbRegCountry.SelectedIndex > -1 && cmbRegStateProv.SelectedIndex > -1)
            {
                btnRegister.Enabled = true;
            }
            else
            {
                btnRegister.Enabled = false;
            }
        }

        private void cmbRegStateProv_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRegStateProv.SelectedIndex > -1 && txtRegHouseNumStreet.Text.Length > 0
                && txtRegPhoneNum.Text.Length == 10 && txtRegName.Text.Length > 0)
            {
                btnRegister.Enabled = true;
            }
            else
            {
                btnRegister.Enabled = false;
            }
        }

        private void cmbRegCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRegCountry.SelectedIndex > -1)
            {
                cmbRegStateProv.Enabled = true;
                cmbRegStateProv.DataSource = Enum.GetValues(cmbRegCountry.SelectedIndex == 0 ? typeof (States) : typeof (Provinces));
            }
            else
            {
                cmbRegStateProv.Enabled = false;
            }
        }

        private void cmbRegStateProv_DataSourceChanged(object sender, EventArgs e)
        {
            cmbRegStateProv.SelectedIndex = -1; // Deselect state/province
        }
    }
}
