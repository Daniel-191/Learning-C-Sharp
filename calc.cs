using system;

class Hello
{
    static voic Main(string[] args)
    {
        // define num1 and num2
        int num1;
        int num2;

        // get user input for numbers
        Console.Write("Enter number: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter number: ");
        num2 = Convert.ToInt32(Console.ReadLIne());

        int total = num1 + num2; // add numbers together

        Console.WriteLine("Total value: " + total); // output total
    }
}