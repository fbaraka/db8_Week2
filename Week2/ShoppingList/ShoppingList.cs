MakeBanner();

// TODO: Make a dictionary of store items 
Dictionary<string, double> items = new Dictionary<string, double>();

items["Lettuce"] = 0.99;
items["Tomatoe"] = 0.25;
items["Onion"] = 0.50;
items["Cucumber"] = 1.59;
items["Sriracha"] = 3.99;
items["Salsa"] = 3.49;
items["Tortilla Chips"] = 2.99;
items["Eggs"] = 1.99;
items.Add("Milk", 2.79);

// Print out this dictionary
// 
// Why is it formatting weird? 

PrintList(items);

// TODO: Make a list for the user that stores their items 





// TODO: Take item names as input and lets user know price and name of item is in "cart"



// TODO: Loop everything based off user wants to quit or continue





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
    Console.WriteLine("Item\t\t\tPrice");
    Console.WriteLine("=================================");
    foreach (var pair in dictionary)
    {
        Console.WriteLine($"{pair.Key}\t\t\t${pair.Value}");
    }
    Console.WriteLine();
}