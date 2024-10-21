using HangMan;

// Create a loop for the program - making it possible to try again.

Random randomWord = new();

int randomIndex = randomWord.Next(0, ListOfWords.ListOfPossibleWords().Count);

// TODO - när hela programmet kan köras igen så kan random ordet bli samma
string newRandomWord = ListOfWords.ListOfPossibleWords()[randomIndex];

int length = newRandomWord.Length;

// Calls the fill function to return a list with the same length but filled with underscores.
List<char> displayedWord = new();
displayedWord = DisplayedWord.Fill(displayedWord, length);


Console.WriteLine("Välkommen till hänga gubbe! Du kommer få gissa bokstäver för ett ord och du kommer få {5} försök.");
foreach (var underscores in displayedWord)
{
    Console.Write(underscores);
}

int lives = 5; // TODO - Kan göras om till försök baserat på ordets längd.
int tryNumber = 1; // Men då måste den här också göras om

bool match = false;
while (lives > 0 && !match)
{
    
    Console.Write($"\nFörsök nummer {{{tryNumber}}}: ");
    bool validCharacter = char.TryParse(Console.ReadLine(), out char guess);
    // TODO - Användaren ska inte kunna gissa samma nummer.
    int correctGuesses = 0;
    List<int> listOfIndexes = new();
    for (int i = 0; i < length; i++)
    {
        if (guess == newRandomWord[i])
        {
            listOfIndexes.Add(i);            
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


    // if the guess was incorrect or the user input wasn't valid => subtract a life.
    if (correctGuesses == 0 || !validCharacter) lives -= 1;
    tryNumber += 1;


    
    // If any characters are different => break. 
    // If it hasn't broken and its the last letter => match found.
    for (int i = 0; i < length; i++)
    {
        if (newRandomWord[i] != displayedWord[i])
        {
            break;
        }
        if (i == length - 1)
        {
            match = true;
        }
    } 
    
}
string result = lives > 0 ? $"\nDu svarade rätt med {lives} liv kvar" : "\nGAME OVER";
Console.WriteLine(result);