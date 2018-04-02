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

            NotifieRss_Form Form = new NotifieRss_Form();
            Application.Run();
        }
    }
}
