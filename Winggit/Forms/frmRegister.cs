using System;
using System.Collections;
using System.Data;
using System.Windows.Forms;
using Winggit.Controls;
using Winggit.Entities;
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
                txtRegName.Text = Winger.currentWinger.Name;
                txtRegPhoneNum.Text = Winger.currentWinger.PhoneNum;
                txtRegHouseNumStreet.Text = Winger.currentWinger.Address;
                txtRegCity.Text = Winger.currentWinger.City;
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
            if (isEditing)
            {
                cmbRegCountry.SelectedIndex = cmbRegCountry.FindString(Winger.currentWinger.Country);
                cmbRegStateProv.SelectedIndex = cmbRegStateProv.FindString(Winger.currentWinger.State);
            }
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
                Hashtable oHash = new Hashtable();
                int count = 0;
                string sql = @"UPDATE Wingers SET";
                if(txtRegName.Text != Winger.currentWinger.Name)
                {
                    oHash.Add("@Name", txtRegName.Text);
                    sql += " Name = @Name";
                    count++;
                }
                if (txtRegPhoneNum.Text != Winger.currentWinger.PhoneNum)
                {
                    if (count > 0)
                    {
                        sql += ",";
                    }
                    oHash.Add("@Phone", txtRegPhoneNum.Text);
                    sql += " PhoneNum = @Phone";
                    count++;
                }
                if (txtRegHouseNumStreet.Text != Winger.currentWinger.Address)
                {
                    if (count > 0)
                    {
                        sql += ",";
                    }
                    oHash.Add("@Address", txtRegHouseNumStreet.Text);
                    sql += " Address = @Address";
                    count++;
                }
                if (txtRegCity.Text != Winger.currentWinger.City)
                {
                    if (count > 0)
                    {
                        sql += ",";
                    }
                    oHash.Add("@City", txtRegCity.Text);
                    sql += " City = @City";
                    count++;
                }
                if (cmbRegCountry.SelectedItem.ToString() != Winger.currentWinger.Country)
                {
                    if (count > 0)
                    {
                        sql += ",";
                    }
                    oHash.Add("@Country", cmbRegCountry.SelectedItem.ToString());
                    sql += " Country = @Country";
                    count++;
                }
                if (cmbRegStateProv.SelectedItem.ToString() != Winger.currentWinger.State)
                {
                    if (count > 0)
                    {
                        sql += ",";
                    }
                    oHash.Add("@State", cmbRegStateProv.SelectedItem.ToString());
                    sql += " State = @State";
                }
                oHash.Add("@WingerNum", Winger.currentWinger.WingerNum);
                sql += " WHERE WingerNum = @WingerNum";
                DBFunctions.RunQuery(sql, oHash);
                oHash = new Hashtable();
                oHash.Add("@WingerNum", Winger.currentWinger.WingerNum);
                sql = "SELECT * FROM Wingers WHERE WingerNum = @WingerNum";
                using (DataSet oDataSet2 = DBFunctions.GetDataSet(sql, oHash))
                {
                    Winger.currentWinger = new Winger(oDataSet2.Tables[0].Rows[0]);
                    MessageBox.Show(@"Congratulations! You have updated the information for Tagger Number #" + oDataSet2.Tables[0].Rows[0]["WingerNum"], @"Congratulations!", MessageBoxButtons.OK);
                    Close();
                }
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
                        oHash.Add("@State", cmbRegStateProv.SelectedItem.ToString());
                        oHash.Add("@Country", cmbRegCountry.SelectedItem.ToString());
                        oHash.Add("@Phone", txtRegPhoneNum.Text.Trim());
                        sql = @"INSERT INTO Wingers OUTPUT Inserted.* VALUES(@Name, @Address, @City, @State, @Country, @Phone, NULL)";
                        using (DataSet oDataSet2 = DBFunctions.GetDataSet(sql, oHash))
                        {
                            Winger.currentWinger = new Winger(oDataSet2.Tables[0].Rows[0]);
                            MessageBox.Show(@"Congratulations! You are registered with Tagger Number #" + oDataSet2.Tables[0].Rows[0]["WingerNum"], @"Congratulations!", MessageBoxButtons.OK);
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
