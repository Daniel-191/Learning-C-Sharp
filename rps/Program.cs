Console.WriteLine("----RPS----");

// Bots hand is decided
string[] rps = { "Rock", "Paper", "Scissors"};
Random random = new Random();
int i = random.Next(rps.Length);
string botChoice = rps[i];

int? input;
string userChoice;

// Menu
Console.WriteLine(@"
1. Rock
2. Paper
3. Scissors
99. Exit
");

Console.Write("> ");
input = Convert.ToInt32(Console.ReadLine());

// Players hand decided
switch (input)
{
    case 1:
        userChoice = rps[input - 1];
    case 2:
        userChoice = rps[input + 1];
    case 3:
        userChoice = rps[input + 2];
    case 99:
        Console.WriteLine("Exiting!...");
        exit();
    default:
        Console.WriteLine("Invalid input.");
}

// decide winner
if (userChoice == botChoice)
{
    Console.WriteLine("Draw!");
}
else if (userChoice == "Rock" && botChoice == "Scissors")
{
    Console.WriteLine("Player Wins!");
}
else if (userChoice == "Scissors" && botChoice == "Paper")
{
    Console.WriteLine("Player Wins!");
}
else if (userChoice == "Paper" && botChoice == "Rock")
{
    Console.WriteLine("Player Wins!");
}
// if none of above conditions met, computer/bot has won.
else
{
    Console.WriteLine("Bot wins!");
}