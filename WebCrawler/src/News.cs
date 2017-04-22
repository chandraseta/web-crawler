using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCrawler.src
{
    public class News
    {
        private string title;
        private string img_url;
        private string description;

        public News(string _title, string _img_url, string _description)
        {
            title = _title;
            img_url = _img_url;
            description = _description;
        }

        public string getTitle()
        {
            return title;
        }

        public string getImgUrl()
        {
            return img_url;
        }

        public string getDescription()
        {
            return description;
        }
    }
}
