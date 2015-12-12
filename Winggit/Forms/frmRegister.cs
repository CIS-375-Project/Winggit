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
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {
            cmbRegCountry.DataSource = Enum.GetValues(typeof (Country));
            btnRegister.Enabled = false;
        }

        private void txtRegPhoneNum_TextChanged(object sender, EventArgs e)
        {
            if (txtRegCity.Text.Length > 0 && txtRegPhoneNum.Text.Length == 10 && txtRegHouseNumStreet.Text.Length > 0
                && cmbRegCountry.SelectedIndex > 0 && cmbRegStateProv.SelectedIndex > 0)
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
                && cmbRegCountry.SelectedIndex > 0 && cmbRegStateProv.SelectedIndex > 0)
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
                && cmbRegCountry.SelectedIndex > 0 && cmbRegStateProv.SelectedIndex > 0)
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
                && cmbRegCountry.SelectedIndex > 0 && cmbRegStateProv.SelectedIndex > 0)
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
            if (cmbRegStateProv.SelectedIndex > 0 && txtRegHouseNumStreet.Text.Length > 0
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
            if (cmbRegCountry.SelectedIndex > 0)
            {
                cmbRegStateProv.Enabled = true;
                cmbRegStateProv.DataSource = Enum.GetValues(cmbRegCountry.SelectedIndex == 1 ? typeof (State) : typeof (Province));
            }
            else
            {
                cmbRegStateProv.Enabled = false;
                cmbRegStateProv.SelectedIndex = -1;
            }
        }

        private void cmbRegStateProv_DataSourceChanged(object sender, EventArgs e)
        {
            cmbRegStateProv.SelectedIndex = -1; // Deselect state/province
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string[] splitAddress = txtRegHouseNumStreet.Text.Split(' ');
            int houseNumber = 0;
            if (splitAddress.Length < 2)
            {
                MessageBox.Show(@"Please enter both your house # and street.", @"Invalid Address", MessageBoxButtons.OK);
                return;
            }

            if (!int.TryParse(splitAddress[0], out houseNumber))
            {
                MessageBox.Show(@"House # not entered, too long, or appears after street.", @"Invalid Address", MessageBoxButtons.OK);
                return;
            }


            // TODO Check if user info exists.
            // TODO try to register a new user with given info.
        }

        private void frmRegister_FormClosing(object sender, FormClosingEventArgs e)
        {
            SystemSounds.Asterisk.Play();
            if (MessageBox.Show(@"Any info you entered will be lost. Proceed?", @"Are you sure?",
                MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
