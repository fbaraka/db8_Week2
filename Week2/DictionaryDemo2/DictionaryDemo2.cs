// More fun with dictionaries 

// A list of salaries. The key will be a persons's name (string),

// and the value will be the person's salary (decimal)

Dictionary<string, decimal> salaries = new Dictionary<string, decimal>();

salaries["Paul"] = 65000m;
salaries["Sarah"] = 100000m;
salaries["Quincy"] = 80000m;
salaries["Ruby"] = 65000m;
salaries["Terry"] = 60000m;
salaries["Fidan"] = 250000m;


//foreach(var pair in salaries)
//{
//    Console.WriteLine(pair.Key);
//}

foreach(string key in salaries.Keys)
{
    Console.WriteLine(key);
}

Console.WriteLine();

Console.WriteLine("Please enter a name: ");
string name = Console.ReadLine();

Console.WriteLine(salaries[name]);

if (salaries.ContainsKey(name))
{
    Console.WriteLine(salaries[name]);
}
else
{
    Console.WriteLine("That person doesn't work here");
}


Console.Write("Please add a new employee. Enter their name: ");
name = Console.ReadLine();

Console.Write("Please enter a salary: ");
string entry = Console.ReadLine();
decimal salary = decimal.Parse(entry);

// salaries[name] = salary;
salaries.Add(name, salary);

Console.WriteLine("Here is everybody: ");
foreach (var pair in salaries)
{
    Console.WriteLine($"{pair.Key} makes {pair.Value}");
}



