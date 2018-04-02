using System;
using System.Windows.Forms;

namespace NotifieRss
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(/*string[] args*/)
        {
            // Run windows form
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new NotifieRss_Form());
        }
    }
}
