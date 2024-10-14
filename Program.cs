

using HangMan;

Random randomWord = new();

int randomIndex = randomWord.Next(0, ListOfWords.ListOfPossibleWords().Count);

// TODO - när hela programmet kan köras igen så kan random ordet bli samma
string newRandomWord = ListOfWords.ListOfPossibleWords()[randomIndex];

int length = newRandomWord.Length;

string displayedWord = DisplayedWord.New(length);

Console.WriteLine("Välkommen till hänga gubbe! Du kommer få gissa bokstäver för ett ord och du kommer få {5} försök.");
Console.WriteLine(displayedWord);

int lives = 5; // TODO - Kan göras om till försök baserat på ordets längd.
int tryNumber = (lives + 1) - lives; // Men då måste den här ocks göras om


while (lives > 0)
{

    Console.Write($"Försök nummer {{{tryNumber}}}: ");
    bool _ = char.TryParse(Console.ReadLine(), out char guess);
    int correctGuesses = 0;
    for (int i = 0; i < length; i++)
    {
        if (guess == newRandomWord[i])
        {
            displayedWord = DisplayedWord.Updated(length, i, newRandomWord, displayedWord);
            correctGuesses += 1;
        }
    }
    if (correctGuesses == 0) lives--;

    Console.WriteLine(displayedWord);
    if (newRandomWord == displayedWord) break;

    
    tryNumber++;
}
string result = lives > 0 ? $"Du svarade rätt med {lives} liv kvar" : "GAME OVER";
Console.WriteLine(result);