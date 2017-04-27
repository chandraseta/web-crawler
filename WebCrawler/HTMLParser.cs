using System.Net.Http;
using HtmlAgilityPack;

namespace WebCrawler
{
    public class HTMLParser
    {
        string news_content;

        public HTMLParser(string url)
        {
            HtmlDocument htmlDoc = new HtmlDocument();
            string html = new HttpClient().GetStringAsync(url).Result;
            htmlDoc.LoadHtml(html);

            var nodes = htmlDoc.DocumentNode.SelectNodes("//p");
            news_content = nodes[0].OuterHtml;
        }
    }
}
