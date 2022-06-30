using System.Collections;

bool runProgram = true;
bool keepShopping = true;
double total = 0;
List<double> prices = new List<double>();

while (runProgram)
{
    Console.WriteLine("Welcome to the Not Healthy Market!");
    while (keepShopping)
    {
        Console.WriteLine(String.Format("{0,1} {1,14}", "Item", "Price"));
        Console.WriteLine("======================");

        Dictionary<string, double> ShoppingList = new Dictionary<string, double>()
        {
            ["candy"] = 0.99,
            ["pop"] = 0.59,
            ["slushie"] = 1.59,
            ["pizza"] = 2.19,
            ["hotdog"] = 1.79,
            ["magazine"] = 2.09,
            ["chips"] = 1.99,
            ["sandwich"] = 3.49
        };
        foreach (KeyValuePair<string, double> kvp in ShoppingList)
        {
            //Display at least 8 item names and prices
            Console.WriteLine(String.Format("{0,1} {1,14}", $"{kvp.Key}", $"${kvp.Value}"));
        }
        Console.WriteLine("What item would you like to order?");








        //Exit strategy
        Console.WriteLine("Would you like to order anything else? y to continue, n to checkout");
        string keepGoing = Console.ReadLine().ToLower().Trim();
        if (keepGoing == ("y"))
        {
            break;
        }
        else if (keepGoing == ("n"))
        {
            runProgram = false;
            break;
        }
    }
}