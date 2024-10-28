using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan
{
    public static class UserGuess 
    {
        public static char GetChar()
        {
            char guess;
            bool validCharacter;
            do
            {
                validCharacter = char.TryParse(Console.ReadLine(), out guess);




            } while (!validCharacter);







            return guess;
        }
    }
}
