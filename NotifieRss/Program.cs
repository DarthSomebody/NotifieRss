using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotifieRss
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            // Default args
            string URL = "";
            string File = "";
            string Keyword = "";
            bool bBackground = false;

            // Parse arguments
            for (int i = 0; i < args.Count(); ++i)
            {
                if (i > 0)
                {
                    // File path
                    if (args[i - 1] == "-file")
                        File = args[i];

                    // RSS URL
                    else if (args[i - 1] == "-rss")
                        URL = args[i];

                    // Keyword
                    else if (args[i - 1] == "-keyword")
                        Keyword = args[i];
                }

                // Run in background
                if (args[i] == "-background")
                    bBackground = true;
            }
            
            if (bBackground)
            {
                NotifieRssWorker Worker = new NotifieRssWorker();
                while (true)
                {
                    Worker.Init(URL, Keyword, File, delegate() { });
                    Worker.Work();
                }
            }
            else
            {
                // Run windows form
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new NotifieRss_Form(URL, Keyword, File));
            }
        }
    }
}
