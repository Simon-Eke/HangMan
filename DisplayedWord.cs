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

        

        // TODO - nån typ av minne och sen overwrite av displayword behövs.
        public static string Updated(int index, char guess, string randomWord, string cheatString)
        {
            char correctLetter = randomWord[index];
            string displayedWord = cheatString.Replace(Convert.ToChar(index), correctLetter);
            for (int i = 0; i < displayedWord.Length; i++)
            {
                if (displayedWord[i] != correctLetter)
                {
                    
                }
            }
            return displayedWord;            
        }
    }
}
