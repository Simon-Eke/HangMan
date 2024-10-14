using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan
{
    internal static class DisplayedWord
    {
        public static string New(int length)
        {
            string displayedWord = "";
            for (int i = 0; i < length; i++)
            {
                displayedWord += '_';
            }
            return displayedWord;
        }

        // TODO - nån typ av minne och sen overwrite av displayword behövs.
        public static string Updated(int length, int index, string randomWord, string displayedWord)
        {
            char correctLetter = randomWord[index];
            foreach (var item in displayedWord)
            {
                if (randomWord.IndexOf(item) == index) { displayedWord += correctLetter; }

            }
            for (int i = 0; i < length; i++)
            {
                if (i == index) { displayedWord += correctLetter; }
                else { displayedWord += '_'; }                
            }
            return displayedWord;            
        }
    }
}
