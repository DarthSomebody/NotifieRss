using System;
using System.Threading;

namespace NotifieRss
{
    /// <summary>
    /// Reads from an RSS feed on a separate thread, until a certain entry is found
    /// </summary>
    class NotifieRssWorker
    {
        /// <summary>
        /// Delegate for OnFinishWork event
        /// </summary>
        public delegate void OnFinishWork();
        
        ///<summary>
        /// The RSS reader class
        ///</summary>
        private RSSReader Reader;

        ///<summary>
        /// The thread
        ///</summary>
        private Thread Worker;

        ///<summary>
        /// Indicator for whether the thread is running
        ///</summary>
        private bool bWorking;
        
        ///<summary>
        ///The URL for the RSS feed
        ///</summary>
        private string URL;

        ///<summary>
        ///The keyword to look out for
        ///</summary>
        private string Keyword;

        ///<summary>   
        /// The file that will be opened upon finishing work
        ///</summary>
        private string File;

        ///<summary>
        /// The minimum date/time
        ///</summary>
        private DateTime Time;

        ///<summary>
        /// The callback function that will be called after the keyword is found
        ///</summary>
        private OnFinishWork Event; 
        


        /// <summary>
        /// Constructor
        /// </summary>
        public NotifieRssWorker()
        {
            Reader = new RSSReader();
            bWorking = false;
        }
                
        /// <summary>
        /// Destructor
        /// </summary>
        ~NotifieRssWorker()
        {
            Stop();
        }
        
        /// <summary>
        /// Sets the needed variables
        /// </summary>
        /// <param name="URL"></param>
        /// <param name="Keyword"></param>
        /// <param name="File"></param>
        /// <param name="Event"></param>
        public void Init(string URL, string Keyword, string File, OnFinishWork Event)
        {
            this.URL = URL;
            this.Keyword = Keyword;
            this.Time = DateTime.Now.ToUniversalTime();
            this.Event = Event;
            this.File = File;
        }
        
        /// <summary>
        /// Starts the worker
        /// </summary>
        public void Start(string URL, string Keyword, string File, OnFinishWork Event)
        {
            if (!bWorking)
            {
                Init(URL, Keyword, File, Event);
                Worker = new Thread(Work);
                Worker.Start();
                bWorking = true;
            }
        }
                
        /// <summary>
        /// Stops the worker
        /// </summary>
        public void Stop()
        {
            if (bWorking)
            {
                Worker.Abort();
                bWorking = false;
            }
        }

        /// <summary>
        /// Worker main loop
        /// </summary>
        public void Work()
        {
            // Parse RSS feed until keyword was found
            while (!Reader.Parse(URL, Keyword, Time))
            {
                Thread.Sleep(15000);
            }

            // Open link
            try { System.Diagnostics.Process.Start(Reader.ResultLink); }
            catch (Exception) { };

            // Open sound file
            try { System.Diagnostics.Process.Start(File); }
            catch (Exception) { };
            
            // Fire OnFinishWork Event
            Event();
        }
    }
}
