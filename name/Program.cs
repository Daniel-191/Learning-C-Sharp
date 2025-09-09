string? name;
string? surname;

Console.Write("Name: ");
name = Console.ReadLine();

Console.Write("Surname: ");
surname = Console.ReadLine();

// concatenate the two strings to form the complete name
// e.g George Jones
Console.WriteLine(name + " " + surname);