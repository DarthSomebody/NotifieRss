using System;
using System.Xml;

namespace NotifieRss
{
    /// <summary>
    /// Helper for loading and parsing an RSS feed
    /// </summary>
    class RSSReader
    {
        /// <summary>
        /// The Link of the RSS entry that was previously found by Parse
        /// </summary>
        public string ResultLink { get; private set; }
        

        /// <summary>
        /// Tries to load a RSS feed from the given URL
        /// </summary>
        /// <param name="URL">The path to the RSS feed</param>
        /// <param name="NodeList">The entries from the RSS feed</param>
        /// <returns>True, if the URL is a valid RSS feed</returns>
        public bool LoadRSS(string URL, out XmlNodeList NodeList)
        {
            // Create instance
            XmlDocument RSS = new XmlDocument();

            // Set node list to null, in case the RSS feed can't be loaded
            NodeList = null;

            // Try to load URL
            try { RSS.Load(URL); }
            catch (Exception) { return false; }

            // Check if it's an RSS feed
            if (RSS.SelectSingleNode("rss/channel") == null)
                return false;

            // Set node list
            NodeList = RSS.SelectNodes("rss/channel/item");
            return true;
        }        

        /// <summary>
        /// Parse the RSS feed from the URL to check if there is an entry with Keyword newer than Time
        /// </summary>
        /// <param name="URL">RSS path</param>
        /// <param name="Keyword">Keyword to search for</param>
        /// <param name="Time">Minimum time for entries to be valid</param>
        /// <returns>True, if a matching entry was found</returns>
        public bool Parse(string URL, string Keyword, ref DateTime Time)
        {
            // Load the RSS file
            XmlNodeList NodeList;
            if (!LoadRSS(URL, out NodeList))
                return false;

            // Iterate through the items in the RSS file
            foreach (XmlNode Node in NodeList)
            {
                // Get time
                DateTime RssTime;
                XmlNode SubNode = Node.SelectSingleNode("pubDate");
                if (!DateTime.TryParseExact(SubNode.InnerText, "yyyy-MM-dd HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.AssumeUniversal, out RssTime))
                    continue;

                // Get title
                SubNode = Node.SelectSingleNode("title");
                string RssTitle = SubNode != null ? SubNode.InnerText : "";

                // Get description
                SubNode = Node.SelectSingleNode("description");
                string RssDescription = SubNode != null ? SubNode.InnerText : "";
                
                // Check if this is what we were looking for
                if (Time < RssTime && (RssTitle.Contains(Keyword) || RssDescription.Contains(Keyword)))
                {
                    // Get link
                    SubNode = Node.SelectSingleNode("link");
                    ResultLink = SubNode != null ? SubNode.InnerText : "";

                    // Change time
                    Time = RssTime.AddMinutes(1.0);

                    // Success
                    return true;
                }
            }

            // Nothing found
            return false;
        }
    }
}
