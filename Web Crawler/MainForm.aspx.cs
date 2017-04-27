﻿using System;
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
                textTyped.Text = "String kosong";
            }
            //baca pilihan dari buttonlist
            buttonSelected.Text = RadioButtonList1.SelectedItem.Text;
            string kalimat = "";
            foreach (News N in NL)
            {
                GetKalimatInIndex get = new GetKalimatInIndex(N.getContent());
                //Console.WriteLine("berita: "+N.getContent());
                if (buttonSelected.Text == "KMP")
                {
                    if (textTyped.Text != "String kosong")
                    {
                        KMP kmp = new KMP(textTyped.Text);
                        
                        //menampilkan indeks dari konten yang dicari
                        index = kmp.searchIn(N.getContent());
                        if(index > 0)
                        { 
                            string url = "<a href=" + N.getUrl()+ ">" +N.getTitle()+ "</a>";
                            kalimat = get.getKalimat(index);
                            contentHasilPencarian.Text += url + "<br><br>" + kalimat + "<br><br><hr>";
                        }
                    }

                }else if(buttonSelected.Text == "Boyer-Moore")
                {
                    if (textTyped.Text != "String kosong")
                    {
                        BoyerMoore boyerMoore = new BoyerMoore(textTyped.Text);
                        
                        //menampilkan indeks dari konten yang dicari
                        index = boyerMoore.searchIn(N.getContent());
                        if (index > 0)
                        {
                            string url = "<a href=" + N.getUrl() + ">" + N.getTitle() + "</a>";
                            kalimat = get.getKalimat(index);
                            contentHasilPencarian.Text += url + "<br><br>" + kalimat + "<br><br><hr>";
                        }

                    }
                }else // Regex
                {
                    if (textTyped.Text != "String kosong")
                    {
                        RegEx regex = new RegEx(textTyped.Text);
                        //menampilkan indeks dari konten yang dicari
                        
                        index = regex.searchIn(N.getContent());
                        if (index > 0)
                        {
                            string url = "<a href=" + N.getUrl() + ">" + N.getTitle() + "</a>";
                            kalimat = get.getKalimat(index);
                            contentHasilPencarian.Text += url + "<br><br>" + kalimat + "<br><br><hr>";
                        }

                    }
                }       
            }
            
            //pesan kesalahan textBoxKosong
            if (textTyped.Text == "String kosong")
            {
                TextBoxKosong.Text = "String tidak boleh kosong!";
            }
            if (textTyped.Text != "String kosong")
            {
                textTyped.Text = "<Tidak ada input text>";
            }

        }
    }
}