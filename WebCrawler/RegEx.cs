using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class RegEx
    {
        private string pattern;
        public RegEx(string userinput)
        {
            pattern = userinput;
        }
        public int Search(string text)
        {
            Match match = Regex.Match(text, @pattern, RegexOptions.IgnoreCase);
            if (match.Success)
            {
                int index = match.Index;
                return index;
            }
            else
            {
                return -1;
            }
        }
    }
}