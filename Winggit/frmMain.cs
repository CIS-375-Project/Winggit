using System;
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
            States userState = States.Michigan;
            switch (userState)
            {
                case States.Michigan:
                case States.Delaware:
                    break;
                case States.Indiana:
                    break;
                case States.Illinois:
                    break;
                case States.Kentucky:
                    break;
                case States.Wisconsin:
                    break;
                case States.Washington:
                    break;
                case States.Oregon:
                    break;
                case States.Wyoming:
                    break;
                case States.Colorado:
                    break;
                case States.Maine:
                    break;
                case States.Vermont:
                    break;
                case States.Maryland:
                    break;
                case States.Massachusetts:
                    break;
                case States.Minnesota:
                    break;
                case States.Kansas:
                    break;
                case States.Nebraska:
                    break;
                case States.Texas:
                    break;
                case States.Florida:
                    break;
                case States.Alaska:
                    break;
                case States.Hawaii:
                    break;
                case States.California:
                    break;
                case States.Nevada:
                    break;
                case States.Oklahoma:
                    break;
                case States.Connecticut:
                    break;
                case States.Virginia:
                    break;
                case States.Georgia:
                    break;
                case States.Tennessee:
                    break;
                case States.Mississippi:
                    break;
                case States.Ohio:
                    break;
                case States.Pennsylvania:
                    break;
                case States.Arizona:
                    break;
                case States.Utah:
                    break;
                case States.Missouri:
                    break;
                case States.Montana:
                    break;
                case States.Alabama:
                    break;
                case States.Louisiana:
                    break;
                case States.New_Mexico:
                    break;
                case States.North_Dakota:
                    break;
                case States.South_Dakota:
                    break;
                case States.North_Carolina:
                    break;
                case States.South_Carolina:
                    break;
                case States.West_Virginia:
                    break;
                case States.New_York:
                    break;
                case States.New_Hampshire:
                    break;
                case States.Rhode_Island:
                    break;
                case States.Idaho:
                    break;
                case States.Arkansas:
                    break;
                case States.Iowa:
                    break;
                case States.Washington_DC:
                    break;
                case States.US_Territories:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private void btnExit_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
