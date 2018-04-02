using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml;

namespace NotifieRss
{
    class TaskManager
    {
        /// <summary>
        /// Delegate for OnFinishWork event
        /// </summary>
        private delegate void ForEach(int ID, TaskListViewItem Item);

        /// <summary>
        /// Workers to read from RSS on another thread
        /// </summary>
        private Dictionary<int, Worker> Workers;

        /// <summary>
        /// List of all tasks
        /// </summary>
        private Dictionary<int, Task> Tasks;

        /// <summary>
        /// Reference to the ListView
        /// </summary>
        private ListView View;


        public TaskManager(ListView View)
        {
            // Init lists
            this.View = View;
            Tasks = new ListSerializer().Load();
            Workers = new Dictionary<int, Worker>();

            // Fill view and workers
            foreach (KeyValuePair<int, Task> Task in Tasks)
            {
                TaskListViewItem Item = new TaskListViewItem(Task.Key, Task.Value);
                Workers.Add(Task.Key, new Worker());
                View.Items.Add(Item);

                // Start task, if autostart is enabled
                if (Task.Value.bAutostart)
                    StartTask(Task.Key, Item);
            }
        }


        public bool AddTask(string URL, string Keyword, string File, bool bAutostart)
        {
            // Check if url is valid
            XmlNodeList NodeList;
            if (!new RSSReader().LoadRSS(URL, out NodeList))
                return false;
                        
            // Create task
            Task Task = new Task();
            Task.URL = URL;
            Task.File = File;
            Task.Keywords = Keyword;
            Task.Interval = 15;
            Task.bAutostart = bAutostart;

            // Add task internally
            int TempID = ListSerializer.GetNewTempID();
            TaskListViewItem Item = new TaskListViewItem(TempID, Task);
            Worker Worker = new Worker();
            View.Items.Add(Item);
            Workers.Add(TempID, Worker);
            Tasks.Add(TempID, Task);
            
            // Start task, if autostart is enabled
            if (Task.bAutostart)
            {
                StartTask(TempID, Item);
            }

            // Save new task
            ListSerializer Serializer = new ListSerializer();
            Serializer.Save(Tasks);
            return true;
        }

        public void RemoveSelectedTasks()
        {
            ForEachSelectedTask(RemoveTask);
            new ListSerializer().Save(Tasks);
        }

        public void StartSelectedTasks()
        {
            ForEachSelectedTask(StartTask);
        }

        public void StopSelectedTasks()
        {
            ForEachSelectedTask(StopTask);
        }

        public void StopAllTasks()
        {
            foreach (TaskListViewItem Item in View.Items)
            {
                StopTask((int)Item.Tag, Item);
            }
        }

        public bool HasSelectedTasks()
        {
            return View.CheckedItems.Count > 0;
        }
        
        private void ForEachSelectedTask(ForEach Delegate)
        {
            foreach (TaskListViewItem Item in View.CheckedItems)
            {
                Delegate((int)Item.Tag, Item);
            }
        }
        
        private void StartTask(int TempID, TaskListViewItem Item)
        {
            Worker Worker = Workers[TempID];
            Worker.Start(Tasks[TempID]);

            Item.SubItems[3].Text = "Running";
        }

        private void StopTask(int TempID, TaskListViewItem Item)
        {            
            Worker Worker = Workers[TempID];
            Worker.Stop();

            Item.SubItems[3].Text = "Stopped";            
        }

        private void RemoveTask(int TempID, TaskListViewItem Item)
        {
            View.Items.Remove(Item);
            foreach (KeyValuePair<int, Task> Task in Tasks)
            {
                if (Task.Key == TempID)
                {
                    Workers.Remove(TempID);
                    Tasks.Remove(TempID);
                    break;
                }
            }
        }
    }
}
