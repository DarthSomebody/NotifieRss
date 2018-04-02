using System;
using System.Threading;

namespace NotifieRss
{
    class Worker
    {
        ///<summary>
        /// The RSS reader class
        ///</summary>
        private RSSReader Reader;

        ///<summary>
        ///The RSS info
        ///</summary>
        private Task Info;

        ///<summary>
        /// The minimum date/time
        ///</summary>
        private DateTime Time;

        ///<summary>
        /// The thread
        ///</summary>
        private Thread WorkerThread;
        
        /// <summary>
        /// Constructor
        /// </summary>
        public Worker()
        {
            Reader = new RSSReader();
        }

        /// <summary>
        /// Destructor
        /// </summary>
        ~Worker()
        {
            Stop();
        }
        
        /// <summary>
        /// Starts the worker.
        /// </summary>
        /// <param name="Info">The task info needed for working.</param>
        public void Start(Task Info)
        {
            // Check if the thread is already running
            if (WorkerThread != null && WorkerThread.IsAlive)
                return;

            // Set needed info
            this.Info = Info;
            this.Time = DateTime.Now.ToUniversalTime();
            this.WorkerThread = new Thread(Work);

            // Start worker
            WorkerThread.Start();
        }

        /// <summary>
        /// Worker main loop.
        /// </summary>
        private void Work()
        {
            while (true)
            {
                // Parse RSS feed until keyword was found
                while (!Reader.Parse(Info.URL, Info.Keywords, Time))
                {
                    Thread.Sleep((int)Info.Interval * 1000);
                }

                // Open link
                try { System.Diagnostics.Process.Start(Reader.ResultLink); }
                catch (Exception) { };

                // Open sound file
                try { System.Diagnostics.Process.Start(Info.File); }
                catch (Exception) { };
            }
        }

        /// <summary>
        /// Stops the worker.
        /// </summary>
        public void Stop()
        {
            try { WorkerThread.Abort(); }
            catch (Exception) { }
        }
    }
}
