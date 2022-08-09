Dictionary<int, string> numToWord = new Dictionary<int, string>();

numToWord[1] = "One";
numToWord[10] = "Ten";
numToWord[20] = "Twenty";
numToWord[100] = "One Hundred";

// Print out all the keys

Console.WriteLine("Here are they keys");
foreach (int key in numToWord.Keys)
{
    Console.WriteLine(key);
}

Console.WriteLine();
Console.WriteLine("here are the values");
foreach (string value in numToWord.Values)
{
    Console.WriteLine(value);
}