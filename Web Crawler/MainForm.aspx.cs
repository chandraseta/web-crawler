using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebCrawler;

namespace Web_Crawler
{
    public partial class MainForm2 : System.Web.UI.Page
    {
        RSSParser RP;
        List<News> NL;
        int index;
        protected void Page_Load(object sender, EventArgs e)
        {
            //loading berita
            string[] rssLink;
            rssLink = new string[1];
            rssLink[0] = "http://www.tempo.co/rss/terkini";

            RP = new RSSParser(rssLink);
            NL = RP.getNews();

            textTyped.Text = string.Empty;
            buttonSelected.Text = string.Empty;
            contentHasilPencarian.Text = string.Empty;
        }

        protected void ButtonClick(object sender, EventArgs e)
        {
            textTyped.Text = TextBox1.Text;
            if (textTyped.Text == string.Empty)
            {
                textTyped.Text = "String tidak boleh kosong";
            }
            //baca pilihan dari buttonlist
            buttonSelected.Text = RadioButtonList1.SelectedItem.Text;
            foreach (News N in NL)
            {
                //Console.WriteLine("berita: "+N.getContent());
                if (buttonSelected.Text == "KMP")
                {
                    if (textTyped.Text != "String tidak boleh kosong")
                    {
                        KMP kmp = new KMP(textTyped.Text);
                        //N.setContent("Aku yang sangat");
                        //menampilkan indeks dari konten yang dicari
                        index = kmp.searchIn(N.getContent());
                        indexHasilPencarian.Text = index.ToString();
                        contentHasilPencarian.Text += "<br><br>"+N.getContent();
                        
                    }

                }
            }


            //buttonSelected.Text = news.getRSSLink();
            //buttonSelected.Text = RadioButtonList1.SelectedItem.Text;
            if (buttonSelected.Text == string.Empty)
            {
                buttonSelected.Text = "Button harus dipilih";
            }

        }
    }
}