using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan
{
    internal static class DisplayedWord
    {
        public static List<char> Fill(List<char> displayedWord, int length)
        {
            for (int i = 0; i < length; i++)
            {
                displayedWord.Add('_');
            }
            return displayedWord;
        }
    }
}
