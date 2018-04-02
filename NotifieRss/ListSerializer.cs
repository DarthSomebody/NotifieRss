using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace NotifieRss
{
    class ListSerializer
    {
        /// <summary>
        /// Counter for IDs
        /// </summary>
        private static int TempID;

        /// <summary>
        /// File to save and load data
        /// </summary>
        private const string TasksFile = "Task.xml";

        /// <summary>
        /// Gets a new ID for a task
        /// </summary>
        /// <returns>A unique ID</returns>
        public static int GetNewTempID()
        {
            return TempID++;
        }

        /// <summary>
        /// Load a list from XML
        /// </summary>
        /// <returns>A lissed filled with data from the Task.xml file</returns>
        public Dictionary<int, Task> Load()
        {
            // Open file
            FileStream FileStream;
            try { FileStream = new FileStream(TasksFile, FileMode.Open, FileAccess.Read, FileShare.Read); }
            catch (Exception) { return new Dictionary<int, Task>(); }

            // Read from file
            BufferedStream BufferedStream = new BufferedStream(FileStream);
            List<Task> TempList = (List<Task>) new XmlSerializer(typeof(List<Task>)).Deserialize(BufferedStream);
            
            // Close file
            BufferedStream.Close();
            FileStream.Close();

            // Put the tasks into a map
            Dictionary<int, Task> TaskList = new Dictionary<int, Task>();
            foreach (Task Info in TempList)
            {
                TaskList.Add(GetNewTempID(), Info);
            }

            return TaskList;
        }

        /// <summary>
        /// Save the list to XML
        /// </summary>
        /// <param name="TaskList">The list that will be saved to the Task.xml</param>
        public void Save(Dictionary<int, Task> TaskList)
        {
            // Write into temp list for serialization
            List<Task> TempList = new List<Task>();
            foreach (KeyValuePair<int, Task> Task in TaskList)
            {
                TempList.Add(Task.Value);
            }

            // Open file
            FileStream FileStream;
            try { FileStream = new FileStream(TasksFile, FileMode.Create, FileAccess.Write, FileShare.None); }
            catch (Exception) { return; }

            // Write to file
            BufferedStream BufferedStream = new BufferedStream(FileStream);
            new XmlSerializer(typeof(List<Task>)).Serialize(BufferedStream, TempList);

            // Close file
            BufferedStream.Close();
            FileStream.Close();
        }
    }
}
