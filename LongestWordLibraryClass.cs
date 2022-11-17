using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestWordLibrary
{
    public class LongestWordLibraryClass
    {
        /// <summary>
        /// Проверка на самое длинное слово
        /// </summary>
        /// <param name="text">
        /// Переменная, содержащая текст
        /// </param>
        /// <returns>
        /// Возвращает строку
        /// </returns>
        public static string FindLongestWord(string text)
        {
            if(text==string.Empty)
            {
                return string.Empty;
            }
            if (text.All(c=>char.IsDigit(c)))
            {
                return string.Empty;
            }
            text =text.Replace("!", "").Replace("?", "");
            var text2 = text.Split(' ',',','.');

            int maxlen = 0, index = 0;
            for (int i = 0; i < text2.Length; i++)
            {
                if (text2[i].Length > maxlen)
                {
                    maxlen = text2[i].Length;
                    index = i;
                }
            }
           return  text2[index].ToLower();
        }
    }
}
