using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Xml;

namespace NotifieRss
{
    public partial class NotifieRss_Form : Form
    {
        /// <summary>
        /// Worker to read from RSS on another thread
        /// </summary>
        private NotifieRssWorker Worker;        



        /// <summary>
        /// Constructor
        /// </summary>
        public NotifieRss_Form(string URL, string Keyword, string File)
        {
            InitializeComponent();

            URL_Box.Text = URL;
            Keyword_Box.Text = Keyword;
            File_Box.Text = File;

            Worker = new NotifieRssWorker();
        }
                
        /// <summary>
        /// Callback for when a worker finishes
        /// </summary>
        private void Finish()
        {
            MethodInvoker Invoker = delegate()
            {
                Cancel_Button.Enabled = false;                
            };

            Invoke(Invoker);
        }
                
        /// <summary>
        /// Click-Event for the file button
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event info</param>
        private void File_Button_Click(object sender, EventArgs e)
        {
            File_Dialog.ShowDialog(this);
        }
        
        /// <summary>
        /// Click-Event for the OK button
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event info</param>
        private void OK_Button_Click(object sender, EventArgs e)
        {
            // Check if url is valid
            XmlNodeList NodeList;
            if (!new RSSReader().LoadRSS(URL_Box.Text, out NodeList))
            {
                MessageBox.Show(this, "Couldn't find RSS feed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Change state of UI elements
            Cancel_Button.Enabled = true;
            OK_Button.Enabled = false;
            URL_Box.Enabled = false;
            Keyword_Box.Enabled = false;
            File_Button.Enabled = false;
            Keyword_Label.Enabled = false;
            URL_Label.Enabled = false;

            // Start worker
            Worker.Start(URL_Box.Text, Keyword_Box.Text, File_Box.Text, Finish);
        }
        
        /// <summary>
        /// Click-Event for the cancel button
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event info</param>
        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            // Stop worker
            Worker.Stop();

            // Change state of UI elements
            Cancel_Button.Enabled = false;
            OK_Button.Enabled = true;
            URL_Box.Enabled = true;
            Keyword_Box.Enabled = true;
            File_Button.Enabled = true;
            Keyword_Label.Enabled = true;
            URL_Label.Enabled = true;
        }
        
        /// <summary>
        /// FileOk-Event for the file dialog
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event info</param>
        private void File_Dialog_FileOk(object sender, CancelEventArgs e)
        {
            File_Box.Text = File_Dialog.FileName;
        }

        /// <summary>
        /// Event for when the text in the URL box changes
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event info</param>
        private void URL_Box_TextChanged(object sender, EventArgs e)
        {
            OK_Button.Enabled = URL_Box.Text.Length > 0;
        }
    }
}
