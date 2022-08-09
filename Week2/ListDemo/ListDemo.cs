// Let's make an array for comparison 

string[] myArray = { "abc", "def", "ghi" };

// let's print out one element 
Console.WriteLine(myArray[0]);

// Let's change one of the members 
myArray[1] = "FFF"
;
// Let's loop through it
for (int i = 0; i < myArray.Length; i++)
{
    Console.WriteLine(myArray[i]);
}

Console.WriteLine();

// 
// Now let's use a List
//

List<string> myList = new List<string>();
Console.WriteLine();
myList.Add("AAA");
myList.Add("BBB");
myList.Add("CCC");

// Let's print out one element 
Console.WriteLine(myList[0]);

myList[1] = "fsb";

// Let's add another one! 
myList.Add("Shk");

for (int i = 0; i < myList.Count; i++)
{
    Console.WriteLine(myList[i]);
}

// delete one from the list 
Console.WriteLine("Lets remove the one at index 2");
myList.RemoveAt(2);

for (int i = 0; i < myList.Count; i++)
{
    Console.WriteLine(myList[i]);
}

Console.WriteLine("Let's remove one by name: Shk");
myList.Remove("Shk)");
Console.WriteLine();
for (int i = 0; i < myList.Count; i++)
{
    Console.WriteLine(myList[i]);
}
// insert one into the list 
// we'll look at the official docs
Console.WriteLine();
Console.WriteLine("Now let's insert one in betweem the first two.");
myList.Insert(1, "aaaaaaaaaaaaapqr");
Console.WriteLine();
foreach (string word in myList)
{
    Console.WriteLine(word);
}
Console.WriteLine();
Console.WriteLine("Let's sort the list");

myList.Sort();

foreach (string nextLetters in myList)
{
    Console.WriteLine(nextLetters);
}
Console.WriteLine();

// Let's check if one exists 
Console.WriteLine("Type in a word and we'll see if it's in the list");
string entry = Console.ReadLine();
int index = myList.IndexOf(entry);

if (index >= 0)
{
    Console.WriteLine($"found {entry} at {index}");
}
else
{
    // In this case we got back a -1, meaning it wasn't found
    Console.WriteLine($"Sorry, {entry} is not found");
}


// lets initialize a list 

List<int> numbers = new List<int>() { 5, 3, 8, 2 };

foreach (int nextNum in numbers)
{
    Console.WriteLine($"The next number is {nextNum}");
}

