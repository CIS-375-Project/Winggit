using System;
using System.Windows.Forms;
using Winggit.Forms;

namespace Winggit.Controls
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogInReg());
        }
    }
}
