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
