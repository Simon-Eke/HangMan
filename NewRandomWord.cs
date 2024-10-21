using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan
{
    internal class NewRandomWord
    {
        private readonly string filePath = @"C:\\Users\Simon\Desktop\listOfHangManWords.txt";
        

        private async Task<string> ReadFile()
        {
            string allWords;
            using (StreamReader reader = new StreamReader(filePath))
            {
                allWords = await reader.ReadToEndAsync();
            }
            return allWords;
        }
        public async Task<string> Get()
        {
            Task<string> myTask = ReadFile();
            string allWords = await myTask;
            string[] arrayOfWords = allWords.Split(' ');
            Random randomIndex = new();

            string newRandomWord = arrayOfWords[randomIndex.Next(0, arrayOfWords.Length)];



            return newRandomWord;
        }
    }
}
