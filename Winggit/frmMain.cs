using System.Windows.Forms;

namespace Winggit
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, System.EventArgs e)
        {
            new frmSearch().Show();
        }
    }
}
