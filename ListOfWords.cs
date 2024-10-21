using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan
{
    public static class ListOfWords
    {
        // TODO - Göra det möjligt att addera ord till listan. (Save to txt.file?)
        // streamreader funktionen 
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
