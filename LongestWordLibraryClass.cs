using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestWordLibrary
{
    public class LongestWordLibraryClass
    {
        public static string FindLongestWord(string text)
        {
            if(text==string.Empty)
            {
                return string.Empty;
            }
            var text2 = text.Replace(",","").Replace(".","").Replace("!","").Replace("?","").Split(' ');
            int maxlen = 0, index = 0;
            for (int i = 0; i < text2.Length; i++)
            {
                if (text2[i].Length > maxlen)
                {
                    maxlen = text2[i].Length;
                    index = i;
                }
            }
           return  text2[index];
        }
    }
}
