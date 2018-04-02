using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace NotifieRss
{
    public partial class NotifieRss_Form : Form
    {
        /// <summary>
        /// The functionality of this form.
        /// </summary>
        TaskManager Manager;
        
        /// <summary>
        /// Constructor
        /// </summary>
        public NotifieRss_Form()
        {
            InitializeComponent();
            Hide();

            Manager = new TaskManager(TaskListView);
        }
                        
        /// <summary>
        /// Click-Event for the file button.
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event info</param>
        private void File_Button_Click(object sender, EventArgs e)
        {
            File_Dialog.ShowDialog(this);
        }
        
        /// <summary>
        /// Click-Event for the start button.
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event info</param>
        private void Start_Button_Click(object sender, EventArgs e)
        {
            Manager.StartSelectedTasks();
        }
        
        /// <summary>
        /// Click-Event for the stop button.
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event info</param>
        private void Stop_Button_Click(object sender, EventArgs e)
        {
            Manager.StopSelectedTasks();
        }
        
        /// <summary>
        /// FileOk-Event for the file dialog.
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event info</param>
        private void File_Dialog_FileOk(object sender, CancelEventArgs e)
        {
            File_Box.Text = File_Dialog.FileName;
        }

        /// <summary>
        /// Click-Event for the add button.
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event info</param>
        private void Add_Button_Click(object sender, EventArgs e)
        {
            // Try to add task
            if (!Manager.AddTask(URL_Box.Text, Keyword_Box.Text, File_Box.Text, Autostart_Checkbox.Checked))
            {
                MessageBox.Show(this, "Couldn't find RSS feed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ResetAddForm();
        }

        /// <summary>
        /// Click-Event for the remove button.
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event info</param>
        private void Remove_Button_Click(object sender, EventArgs e)
        {
            Manager.RemoveSelectedTasks();
        }

        /// <summary>
        /// Event for closing the form.
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event info</param>
        private void NotifieRss_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Manager.StopAllTasks();
            Application.Exit();
        }

        /// <summary>
        /// Click-Event for the clear button
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event info</param>
        private void Clear_Button_Click(object sender, EventArgs e)
        {
            ResetAddForm();
        }

        /// <summary>
        /// Event for changing the checked status of the list
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event info</param>
        private void TaskListView_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            bool bHasSelectedTasks = Manager.HasSelectedTasks();
            Stop_Button.Enabled = bHasSelectedTasks;
            Start_Button.Enabled = bHasSelectedTasks;
            Remove_Button.Enabled = bHasSelectedTasks;
        }

        /// <summary>
        /// Resets the form elements that are used to add a new task.
        /// </summary>
        private void ResetAddForm()
        {
            // Reset form elements
            URL_Box.Text = "";
            Keyword_Box.Text = "";
            File_Box.Text = "";
            Autostart_Checkbox.Checked = true;
            File_Dialog.Reset();
        }

        /// <summary>
        /// Minimize/maximize event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event info</param>
        private void NotifieRss_Form_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                TrayIcon.Visible = true;
                Hide();
            }

            else if (WindowState == FormWindowState.Normal)
            {
                TrayIcon.Visible = false;
            }
        }

        /// <summary>
        /// Tray icon double click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event info</param>
        private void TrayIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }
    }
}
