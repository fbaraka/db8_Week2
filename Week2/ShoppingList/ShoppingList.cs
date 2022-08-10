MakeBanner();

// TODO: Make a dictionary of store items 
Dictionary<string, double> storeItems = new Dictionary<string, double>();

storeItems["Lettuce"] = 0.99;
storeItems["Tomatoe"] = 0.25;
storeItems["Onion"] = 0.59;
storeItems["Cucumber"] = 1.59;
storeItems["Sriracha"] = 3.99;
storeItems["Salsa"] = 3.49;
storeItems["Chips"] = 2.99;
storeItems["Eggs"] = 1.99;
storeItems.Add("Milk", 2.79);



// TODO: Make a list for the user that stores their items 

List<string> userShoppingList = new List<string>();


do
{

    // TODO: Print out this dictionary
    PrintList(storeItems);

    // TODO: Take item names as input and lets user know price and name of item is in "cart"
    Console.WriteLine();
    Console.Write("What items would you like to order? ");
    string userInput = Console.ReadLine();

    if (storeItems.ContainsKey(userInput))
    {
        Console.WriteLine($"Adding {userInput} to cart at ${storeItems[userInput]}");
        userShoppingList.Add(userInput);
        Console.WriteLine();
    }
    else
    {
        Console.WriteLine("Sorry we don't have that item!");
    }

    // TODO: Loop everything based off user wants to add another item

} while (AddAnotherItem());


// Display their list of their ordered items with prices as well and sum all the prices of items 
// use the list to reference our dictionary 
Console.WriteLine();
Console.WriteLine("Thank you for your order!");
Console.WriteLine();
Console.WriteLine("Here's what you got:");

// List<string> SortedShoppingList = new List<string>();

foreach (var userItem in userShoppingList)
{
    Console.WriteLine($"{userItem,-10}${storeItems[userItem]}");
}

double totalPrice = 0.00;

foreach (var userItem in userShoppingList)
{
    totalPrice = totalPrice + storeItems[userItem];
}

Console.WriteLine();
Console.WriteLine($"Your total is ${totalPrice}");


static void MakeBanner()
{
    Console.WriteLine();
    Console.WriteLine("=================================================");
    Console.WriteLine("          Welcome to Windfall Market!            ");
    Console.WriteLine("=================================================");
    Console.WriteLine();
    Console.WriteLine();
}

static void PrintList(Dictionary<string, double> dictionary)
{
    string itemTitle = "Item";
    Console.WriteLine($"{itemTitle, -19} Price");
    Console.WriteLine("=================================");
    foreach (var pair in dictionary)
    {
        Console.WriteLine($"{pair.Key,-20}${pair.Value}");
    }
    Console.WriteLine();
}

static bool AddAnotherItem()
{
    while (true)
    {
        Console.WriteLine("Would you like to add another item? (y/n)");
        string response = Console.ReadLine();
        response = response.ToLower();
        if (response == "y" || response == "yes")
        {
            return true;
        }
        else if (response == "n" || response == "no")
        {
            return false;
        }
        else
        {
            Console.WriteLine("Please enter y or n");
        }
    }
}