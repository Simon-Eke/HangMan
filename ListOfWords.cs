using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan
{
    public static class ListOfWords
    {
        public static List<string> ListOfPossibleWords()
        {
            List<string> listOfWords = 
            [
               "yxa",
               "kantarell",
               "strumpa", 
               "skjul",
               "stjärna",
               "begagnad",
               "filament",
               "sekretess",
               "trevlig",
               "student",
               "redskap",
               "chaufför",
               "huvudstad",
               "garnityr",
               "fjäsk",
               "hjärna",
               "strandsatt",
               "fantasi",
               "xylofon"
            ];
            return listOfWords;
        }
    }
}
