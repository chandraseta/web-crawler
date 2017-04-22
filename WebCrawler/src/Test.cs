using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCrawler.src
{
    public class Test
    {
        public static void Main(string[] args)
        {
            /*
            string keyword;
            string text;

            Console.WriteLine("Enter the whole text");
            text = Console.ReadLine();
            Console.WriteLine("Enter the keyword to be searched");
            keyword = Console.ReadLine();

            BoyerMoore BM = new BoyerMoore(keyword);
            int idx_found = BM.Search(text);
            if (idx_found != -1)
            {
                Console.WriteLine("Keyword found at index: {0}", idx_found);
            }
            else
            {
                Console.WriteLine("Keyword not found in text");
            }

            KMP K = new KMP(keyword);
            idx_found = K.Search(text);
            if (idx_found != -1)
            {
                Console.WriteLine("Keyword found at index: {0}", idx_found);
            }
            else
            {
                Console.WriteLine("Keyword not found in text");
            }
            */

            string[] rssLink;
            rssLink = new string[1];
            rssLink[0] = "http://rss.detik.com/index.php/detikcom";

            RSSParser RP = new RSSParser(rssLink);
            List<News> NL = RP.getNews();
            foreach (News N in NL)
            {
                Console.WriteLine("Title: {0}", N.getTitle());
                Console.WriteLine("img_url: {0}", N.getImgUrl());
                Console.WriteLine("Description: {0}", N.getDescription());
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();

        }
    }
}
