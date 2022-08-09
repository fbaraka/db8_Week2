// Let's start with a list for comparison

List<string> letters = new List<string>();

letters.Add("abc");
letters.Add("def");
letters.Add("ghi");
letters.Add("jkl");
letters.Add("mno");

Console.WriteLine("Here are the letters");

foreach (string nextLetter in letters)
{
    Console.WriteLine($"Here are the next letters: {nextLetter}");
}

Dictionary<string, string> foods = new Dictionary<string, string>();

foods["Paul"] = "Spaghetti";
foods["Sarah"] = "Pizza";
foods["Quincy"] = "Tacos";
foods["Ruby"] = "Ice Cream";
foods["Terry"] = "Tacos";

// Let's print out Ruby's favorite food
Console.WriteLine("Here is Ruby's favorite food:");
Console.WriteLine(foods["Ruby"]);

// Paul changed his mind. He likes Hamburgers. 
foods["Paul"] = "Hamburgers";
Console.WriteLine($"Paul now Likes {foods["Paul"]}");


Console.WriteLine();

foreach (var pair in foods)
{
    Console.WriteLine("The name and the food are: ");
    Console.WriteLine(pair.Key);    // The perspon's name
    Console.WriteLine(pair.Value);  // their favorite food
}


// Check if an item exists in the dictionary 
Console.WriteLine();
string entry = Console.ReadLine();

if (foods.ContainsKey(entry))
{
    Console.WriteLine($"Yes, we have a favorite food for {entry}");
    Console.WriteLine(foods[entry]);
}
else
{
    Console.WriteLine("We don't know that person");
}
