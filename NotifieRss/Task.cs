using System;
using System.Windows.Forms;

namespace NotifieRss
{
    /// <summary>
    /// A serializable struct that describes a task
    /// </summary>
    [Serializable]
    public struct Task
    {
        public string URL { get; set; }
        public string Keywords { get; set; }
        public string File { get; set; }
        public uint Interval { get; set; }
        public bool bAutostart { get; set; }        
    }
    
    /// <summary>
    /// A list view item for tasks
    /// </summary>
    public class TaskListViewItem : ListViewItem
    {
        public TaskListViewItem(int ID, Task Info)
            : base (GetRSSAttributes(Info))
        {           
            this.Tag = ID;
        }

        private static string[] GetRSSAttributes(Task Info)
        {
            string[] FilePath = Info.File.Split('\\');
            return new string[] { Info.URL, Info.Keywords, FilePath[FilePath.Length - 1], "Stopped" };
        }
    }
}