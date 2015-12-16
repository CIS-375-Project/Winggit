using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winggit.Controls;
using Winggit.Entities;

namespace Winggit.Forms
{
    public partial class frmPokedex : Form
    {
        public frmPokedex()
        {
            InitializeComponent();
        }

        

        private void frmPokedex_Load(object sender, EventArgs e)
        {
            // Load data from the database
            Hashtable oHash = new Hashtable();
            string sql = "SELECT W.Name, COUNT(DISTINCT T.TagID) AS 'Number of Tags', W.Percent_Complete AS 'Completion Percent' FROM Wingers AS W JOIN Tags AS T ON W.WingerNum = T.WingerNum GROUP BY W.Name, W.Percent_Complete, W.WingerNum ORDER BY W.WingerNum";
            using (DataSet oDataSet = DBFunctions.GetDataSet(sql, oHash))
            {
                if (oDataSet.Tables.Count == 0 || oDataSet.Tables[0].Rows.Count == 0)
                {
                    return;
                }

                dgdTaggerRankings.DataSource = oDataSet.Tables[0];
                dgdTaggerRankings.AllowUserToAddRows = false;
                dgdTaggerRankings.ReadOnly = true;

            }


        }

        private void btnRefreshRankings_Click(object sender, EventArgs e)
        {
            // refresh table from the database
            dgdTaggerRankings.ClearSelection();


            Hashtable oHash = new Hashtable();
            string sql = "SELECT W.Name, COUNT(DISTINCT T.TagID) AS 'Number of Tags', W.Percent_Complete AS 'Completion Percent' FROM Wingers AS W JOIN Tags AS T ON W.WingerNum = T.WingerNum GROUP BY W.Name, W.Percent_Complete, W.WingerNum ORDER BY W.WingerNum";
            using (DataSet oDataSet = DBFunctions.GetDataSet(sql, oHash))
            {
                if (oDataSet.Tables.Count == 0 || oDataSet.Tables[0].Rows.Count == 0)
                {
                    return;
                }

                dgdTaggerRankings.DataSource = oDataSet.Tables[0];
                dgdTaggerRankings.AllowUserToAddRows = false;
                dgdTaggerRankings.ReadOnly = true;

            }
        }

        private void frmPokedex_FormClosing(object sender, FormClosingEventArgs e)
        {
            SystemSounds.Asterisk.Play();
            if (MessageBox.Show(@"About to return to main menu. Proceed?", @"Leave Pokédex?", MessageBoxButtons.YesNo) ==
                DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
