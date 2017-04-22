using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCrawler.src
{
    public class KMP
    {
        private string pattern;
        private int[] border;

        public KMP(string keyword)
        {
            pattern = String.Copy(keyword);
            border = new int[pattern.Length];
            border = CreateBorder();
        }

        public int[] CreateBorder()
        {
            int[] res = new int[pattern.Length];
            res[0] = 0;
            
            int len = pattern.Length;
            int j = 0;
            int idx = 1;

            while (idx < len)
            {
                if (pattern[j] == pattern[idx])
                {
                    res[idx] = j + 1;
                    idx++;
                    j++;
                }
                else if (j > 0)
                {
                    j = res[j - 1];
                }
                else
                {
                    res[idx] = 0;
                    idx++;
                }
            }

            return res;
        }

        public int Search(string text)
        {
            int text_length = text.Length;
            int pattern_length = pattern.Length;

            int text_idx = 0;
            int pattern_idx = 0;

            while (text_idx < text_length)
            {
                if (pattern[pattern_idx] == text[text_idx])
                {
                    if (pattern_idx == pattern_length-1)
                    {
                        return text_idx - pattern_length + 1;
                    }
                    text_idx++;
                    pattern_idx++;
                }
                else if (pattern_idx > 0)
                {
                    pattern_idx = border[pattern_idx - 1];
                }
                else
                {
                    text_idx++;
                }
            }
            return -1;
        }
    }
}
