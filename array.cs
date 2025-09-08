using system;

class ShoppingList
{
    static void Main(string[] args)
    {
        Console.WriteLine("----Arrays-----");

        // define string array
        string[] ShoppingList;
        int totalitems = 0; // this will iterate when item added
        string item = "placeholder"; // placeholder string (probs not even needed)

        // Will run forever until user enters 'exit'
        while (item != "exit")
        {
            // output number of items
            Console.WriteLine("Number of items in list: " + totalitems + ".");

            // Get user input for next item
            Console.WriteLine("Enter item (enter exit to exit): ");
            item = Console.ReadLine(); // fetch input

            // Append item to list
            if (item != "exit")
            {
                ShoppingList = ShoppingList.Append(item).ToArray(); // append arra
                Console.WriteLine(item + " Added to the shopping list!");
                totalitems++; // iterate total item number
            }
            else
            {
                Console.WriteLine("Exiting...");
                break; // break off loop
            }
        }

        // Now that loop is done
        // Output shopping list
        // Loops through every value in array
        int m = 1;
        foreach (string i in ShoppingList)
        {
            // Output list 1 by one 
            // In format '1. item' , '2. item' etc...
            Console.WriteLine(m + ". " + i);
            //Console.WriteLine("\n");
        }

    }
}