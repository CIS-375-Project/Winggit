using System;
using System.Windows.Forms;

namespace Winggit
{
    public partial class frmMessagingClient : Form
    {
        public frmMessagingClient()
        {
            InitializeComponent();
        }

        private void btnCancelMessaging_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
