using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;

namespace WebCrawler.src
{
    public class RSSParser
    {
        private List<News> NewsFeed = new List<News>();

        public RSSParser(string[] RSSLinks)
        {
            XmlDocument rssXmlDoc = new XmlDocument();
            Console.WriteLine("In process: RSSParser");
            for (int i=0; i<RSSLinks.Length; i++)
            {
                rssXmlDoc.Load(RSSLinks[i]);
                XmlNodeList rssNodes = rssXmlDoc.SelectNodes("rss/channel/item");
                Console.WriteLine("In loop: RSSParser Length");
                foreach (XmlNode rssNode in rssNodes)
                {
                    Console.WriteLine("In loop: RSSParser Nodes");
                    XmlNode rssSubNode = rssNode.SelectSingleNode("title");
                    string title = rssSubNode != null ? rssSubNode.InnerText : "";

                    rssSubNode = rssNode.SelectSingleNode("url");
                    string img_url = rssSubNode != null ? rssSubNode.InnerText : "";

                    rssSubNode = rssNode.SelectSingleNode("description");
                    string description = rssSubNode != null ? rssSubNode.InnerText : "";

                    News rssNews = new News(title, img_url, description);
                    NewsFeed.Add(rssNews);
                }
            }
        }

        public List<News> getNews()
        {
            return NewsFeed;
        }
    }
}
