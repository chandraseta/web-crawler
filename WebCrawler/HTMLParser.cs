using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace WebCrawler.src
{
    public class HTMLParser
    {
        string news_content;

        public HTMLParser(string url)
        {
            HtmlDocument htmlDoc = new HtmlDocument();
            string html = new HttpClient().GetStringAsync(url).Result;
            htmlDoc.LoadHtml(html);

            var nodes = htmlDoc.DocumentNode.SelectSingleNode("//p");
            news_content = nodes[0].OuterHtml;
        }
    }
}
