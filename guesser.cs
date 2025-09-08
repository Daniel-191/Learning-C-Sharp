using sytstem;

class Gusser
{
    static void Main(string[] args)
    {
        Console.WriteLine("----Number Guesser----");

        Random rnd = new Random(); // define random func
        int toguess = rnd.Next(1, 100); // generate random number
        int guess; // stores users most recent guess
        int attempts = 0; // number of guesses (starts at 0 and interates)

        while (toguess != guess)
        {
            // Get user input
            Console.WriteLine("Enter number to guess: (1-100) ");
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
                Console.WriteLine("Correct! The number was " + toguess + "!");
                Console.WriteLine("You guessed it in " + attempts + " attempts!");
            }
        }

        // Look breaks after number was guessed
    }
}