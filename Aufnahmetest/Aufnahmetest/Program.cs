using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using WindowsFormsApp3;
using System.Security.Principal;

namespace Aufnahmetest
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
            

            WindowsIdentity identity = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new WindowsPrincipal(identity);
            /*
            if (!principal.IsInRole(WindowsBuiltInRole.Administrator))
            {
                Application.Run(new Start_Screen()); //kein Admin
            }
            else
            {
                Application.Run(new TEST());//Admin
            }
            */
            Application.Run(new Frm_Test());

        }
    }
}
