
Console.WriteLine("----Number Guesser----");

Random rnd = new Random(); // define random func
int toguess = rnd.Next(1, 100); // generate random number
int guess = 0; // stores users most recent guess
int attempts = 0; // number of guesses (starts at 0 and interates)
bool play = true;
char playAgain;

while (play)
{
    // Get user input
    Console.Write("Enter number to guess: (1-100) ");
    guess = Convert.ToInt32(Console.ReadLine());

    attempts++; // iterates number of guesses

    // Number guessing logic
    if (guess > 100 || guess < 1) // logic checking (if user inputs an INVALID number it returns with an err)
    {
        Console.WriteLine("Number must be between 1 and 100");
    }
    else if (guess > toguess)
    {
        Console.WriteLine("Lower");
    }
    else if (guess < toguess)
    {
        Console.WriteLine("Higher");
    }
    else if (guess == toguess)
    {
        Console.WriteLine("\nCorrect! The number was " + toguess + "!");
        Console.WriteLine("You guessed the number in " + attempts + " attempts!");
    }

    // get input from user to play again
    Console.Write("\nWould you Like to play again?: (y/n) ");
    playAgain = Convert.ToChar(Console.ReadLine());

    // see if user plays again
    if (playAgain == 'y')
    {
        Console.Write("");
    }
    else if (playAgain == 'n')
    {
        play = false;  
        break; // break off func (game ends)
    }

}

// Look breaks after number was guessed