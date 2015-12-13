using System;
using System.Media;
using System.Windows.Forms;
using Winggit.Enums;

namespace Winggit.Forms
{
    public partial class frmRegister : Form
    {
        private readonly bool isEditing;
        public frmRegister(bool isEd)
        {
            isEditing = isEd;
            InitializeComponent();
            if (isEditing)
            {
                Text = @"Edit Your Info";
                btnRegister.Text = @"Finish";
            }
        }

        public sealed override string Text
        {
            get { return base.Text; }
            set { base.Text = value; }
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

            if (isEditing)
            {
                
                // TODO Set user info to values in text fields
                // TODO Send updated user info to database.
            }
            else
            {
                Hashtable oHash = new Hashtable();
                oHash.Add("@Name", txtRegName.Text.Trim());
                oHash.Add("@Address", txtRegHouseNumStreet.Text.Trim());
                oHash.Add("@Phone", txtRegPhoneNum.Text.Trim());
                string sql = "SELECT * FROM Wingers WHERE Name = @Name AND Address = @Address AND PhoneNum = @Phone";
                using (DataSet oDataSet = DBFunctions.GetDataSet(sql, oHash))
                {
                    if (oDataSet.Tables.Count == 0 || oDataSet.Tables[0].Rows.Count == 0)
                    {
                        oHash = new Hashtable();
                        oHash.Add("@Name", txtRegName.Text.Trim());
                        oHash.Add("@Address", txtRegHouseNumStreet.Text.Trim());
                        oHash.Add("@City", txtRegCity.Text.Trim());
                        oHash.Add("@State", cmbRegStateProv.SelectedText);
                        oHash.Add("@Country", cmbRegCountry.SelectedText);
                        oHash.Add("@Phone", txtRegPhoneNum.Text.Trim());
                        sql = @"INSERT INTO Wingers OUTPUT Inserted.* VALUES(@Name, @Address, @City, @State, @Country, @Phone, NULL)";
                        using (DataSet oDataSet2 = DBFunctions.GetDataSet(sql, oHash))
                        {
                            Winger.currentWinger = new Winger(oDataSet2.Tables[0].Rows[0]);
                            MessageBox.Show("Congradulations! You are registered with Tagger Number #" + oDataSet2.Tables[0].Rows[0]["WingerNum"], "Congradulations!", MessageBoxButtons.OK);
                            Close();
                        }
                    }
                }
        }
            Close();
        }

        private void btnCancelReg_Click(object sender, EventArgs e)
            {
            Close();
        }
    }
}
