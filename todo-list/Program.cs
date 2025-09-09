Console.WriteLine("----Simple TODO List----\n");

// List
// Format of creating a list:
// List<typevar> NAME = new list<typevar>(MAXVALUES);
List<string> TodoList = new List<string>(); // Creates dynamic list with no max
// Add to list using:
// TodoList.Add("Information");
// Rem from list using:
// TodoList.Remove("Information");
// Clear list: TodoList.Clear();
// Loop THROUGH a list using:
// foreach (string i in TodoList)

// Other variables
int? option;
bool running = true;


static void ListManaging(string type, List<string> TodoList)
{
    bool managing = true;
    string? item;

    if (type == "add")
    {
        // Code for adding items from list
        while (managing)
        {
            Console.Write("Enter item to add to list: ");
            item = Console.ReadLine();

            if (item == "exit") { managing = false; break; }

            TodoList.Add(item);
        }
    }
    else if (type == "rem")
    {
        // Code for removing items from list
        while (managing)
        {
            if (TodoList.Count == 0) { Console.WriteLine("Todo list is empty!"); }

            // Loops through and outputs list
            int count = 0;
            foreach (string i in TodoList)
            {
                count++;
                Console.WriteLine(count + ". " + i);
            }

            Console.Write("\nEnter item name to rem from list: ");
            item = Console.ReadLine();

            if (item == "exit") { managing = false; break; }

            TodoList.Remove(item);
        }
    }
}

// Outputs list
static void ViewList(List<string> TodoList)
{
    int count = 0;

    if (TodoList.Count == 0)
    {
        Console.WriteLine("Todo list is empty!");
    }
    else
    {
        foreach (string i in TodoList)
        {
            count++;
            Console.WriteLine(count + ". " + i);
        }
    }

    Console.Write("\nPress Enter to Continue... ");
    Console.ReadLine();
}


// Menu
while (running)
{
    Console.WriteLine(@"
What would you like to do:
1. Add to list
2. Rem from list
3. View list
99. Exit");

    Console.Write("\n\n> ");
    option = Convert.ToInt32(Console.ReadLine());

    // Using switch case cuz why tf not
    switch (option)
    {
        case 1:
            ListManaging("add", TodoList);
            break;
        case 2:
            ListManaging("rem", TodoList);
            break;
        case 3:
            ViewList(TodoList);
            break;
        case 99:
            Console.WriteLine("Exiting!");
            running = false;
            break;
        default:
            Console.WriteLine("\n\nInvalid input! Enter 1, 2 or 99");
            break;
    }
}