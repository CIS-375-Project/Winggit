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
            string SQL = "SELECT * FROM Wingers WHERE WingerNum = '" + txtLogInID.Text.Trim() + "'";
            using (DataSet oDataSet = DBFunctions.getDataset(SQL))
            {
                if (oDataSet.Tables.Count == 0 || oDataSet.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("User not found", "Winggit", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
                Winger.currentWinger = new Winger(oDataSet.Tables[0].Rows[0]);
            }
            frmMain main = new frmMain();
            main.Show();
            Close();
        }

        private void txtLogInID_TextChanged(object sender, EventArgs e)
        {
            btnLogIn.Enabled = txtLogInID.Text.Length > 0;
        }

        private void txtLogInID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ensures only numbers are entered.
            }
        }
    }
}
