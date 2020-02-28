using HospitalAdminApp.View;
using System;
using System.Threading;
using System.Windows.Forms;

namespace HospitalAdminApp
{
    /// <summary>
    /// This class creates the start of the application. 
    /// </summary>
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool instance = false;
            using (Mutex mtex = new Mutex(true, "Login Instance", out instance))
            {
                if (instance)
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new FormLogin());
                    mtex.ReleaseMutex();
                }
                else
                {
                    MessageBox.Show("This application is already running.");
                }
            }

        }
    }
}
