

using HangMan;

Random randomWord = new();

int randomIndex = randomWord.Next(0, ListOfWords.ListOfPossibleWords().Count);

// TODO - när hela programmet kan köras igen så kan random ordet bli samma
string newRandomWord = ListOfWords.ListOfPossibleWords()[randomIndex];

int length = newRandomWord.Length;

List<char> displayedWord = new();
displayedWord = DisplayedWord.Fill(displayedWord, length);


Console.WriteLine("Välkommen till hänga gubbe! Du kommer få gissa bokstäver för ett ord och du kommer få {5} försök.");

foreach (var letter in displayedWord)
{
    Console.Write(letter);
}

int lives = 5; // TODO - Kan göras om till försök baserat på ordets längd.
int tryNumber = (lives + 1) - lives; // Men då måste den här ocks göras om


while (lives > 0)
{

    Console.Write($"\nFörsök nummer {{{tryNumber}}}: ");
    bool _ = char.TryParse(Console.ReadLine(), out char guess);
    int correctGuesses = 0;
    List<int> listOfIndexes = new();
    for (int i = 0; i < length; i++)
    {
        if (guess == newRandomWord[i])
        {
            listOfIndexes.Add(i);
            //displayedWord = DisplayedWord.Updated(i, guess, cheatString);
            correctGuesses += 1;
        }
    }

    for (int i = 0; i < listOfIndexes.Count; i++)
    {
        displayedWord[listOfIndexes[i]] = guess;
    }


    foreach (var letter in displayedWord)
    {
        Console.Write(letter);
    }
    if (correctGuesses == 0 || !_) lives--;
    tryNumber++;

    
    //if (newRandomWord == displayedWord) break;



}
string result = lives > 0 ? $"Du svarade rätt med {lives} liv kvar" : "GAME OVER";
Console.WriteLine(result);