using HangMan;

// TODO - Create a loop for the program - making it possible to try again.
int lives;
NewRandomWord newWord = new();
HashSet<string> wordsAlreadyPlayed = new();
int gameCounter = 0;
int highScore = 0;
do
{
    // User Interface
    // and add to file.

    // Read from file 

    
    string randomWord;
    
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





    List<char> alreadyGuessedLetters = new();
    lives = 5; // TODO - Kan göras om till försök baserat på ordets längd.
    int tryNumber = 1; // Men då måste den här också göras om

    bool correctGuess = false;
    while (lives > 0 && !correctGuess)
    {
        Console.Clear();
        Console.WriteLine($"Välkommen till hänga gubbe! Du kommer få gissa bokstäver för ett ord. Du har {lives} liv kvar.");
        Console.WriteLine($"Highscore: {highScore}");
        foreach (var letter in displayedWord)
        {
            Console.Write(letter);
        }
        string alreadyGuessed = " ";
        foreach (var guessedLetter in alreadyGuessedLetters)
        {
            alreadyGuessed += guessedLetter;
            alreadyGuessed += " ";
        }
        Console.WriteLine($"\nRedan gissade bokstäver: {alreadyGuessed}");
        Console.Write($"\nFörsök nummer {{{tryNumber}}}: ");

        char guess = UserGuess.GetChar();
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

        for (int i = 0; i < listOfIndexes.Count; i++)
        {
            displayedWord[listOfIndexes[i]] = guess;
        }






        // if the guess was incorrect or the user input wasn't valid => subtract a life.
        if (correctGuesses == 0) lives -= 1;
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
                highScore++;
                correctGuess = true;
            }
        }

    }
    string result = lives > 0 ? $"\nDu svarade rätt med {lives} liv kvar" : "\nGAME OVER";
    Console.WriteLine(result);
} while (lives > 0);