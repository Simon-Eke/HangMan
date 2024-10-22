using HangMan;

// TODO - Create a loop for the program - making it possible to try again.

// User Interface
// and add to file.

// Read from file 

NewRandomWord newWord = new();
HashSet<string> wordsAlreadyPlayed = new();
string randomWord;
int gameCounter = 0;
gameCounter++;
do
{
    randomWord = await newWord.Get();
    wordsAlreadyPlayed.Add(randomWord);
} while (wordsAlreadyPlayed.Count != gameCounter);



int length = randomWord.Length;

// Calls the fill function to return a list with the same length but filled with underscores.
List<char> displayedWord = new();
displayedWord = DisplayedWord.Fill(displayedWord, length);


Console.WriteLine("Välkommen till hänga gubbe! Du kommer få gissa bokstäver för ett ord och du kommer få {5} försök.");
foreach (var underscores in displayedWord)
{
    Console.Write(underscores);
}

List<char> alreadyGuessedLetters = new();
int lives = 5; // TODO - Kan göras om till försök baserat på ordets längd.
int tryNumber = 1; // Men då måste den här också göras om

bool correctGuess = false;
while (lives > 0 && !correctGuess)
{
    
    Console.Write($"\nFörsök nummer {{{tryNumber}}}: ");
    bool validCharacter = char.TryParse(Console.ReadLine(), out char guess);
    // TODO - Användaren ska inte kunna gissa samma nummer.
    alreadyGuessedLetters.Add(guess);
    int correctGuesses = 0;
    List<int> listOfIndexes = new();
    for (int i = 0; i < length; i++)
    {
        if (guess == randomWord[i])
        {
            listOfIndexes.Add(i);            
            correctGuesses += 1;
        }
    }
    //Console.Clear();
    for (int i = 0; i < listOfIndexes.Count; i++)
    {
        displayedWord[listOfIndexes[i]] = guess;
    }

    string alreadyGuessed = " ";
    foreach (var guessedLetter in alreadyGuessedLetters)
    {
        alreadyGuessed += guessedLetter;
        alreadyGuessed += " ";
    }
    Console.WriteLine($"Redan gissade bokstäver: {alreadyGuessed}");

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
        if (randomWord[i] != displayedWord[i])
        {
            break;
        }
        if (i == length - 1)
        {
            correctGuess = true;
        }
    } 
    
}
string result = lives > 0 ? $"\nDu svarade rätt med {lives} liv kvar" : "\nGAME OVER";
Console.WriteLine(result);