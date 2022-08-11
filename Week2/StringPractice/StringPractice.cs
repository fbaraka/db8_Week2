string sentence = "Hello there everybody from planet earth";

string[] words = sentence.Split();

foreach (string word in words)
{
    Console.WriteLine(word);
}


Console.WriteLine();
Console.WriteLine("Split by commas"); 
Console.WriteLine();

sentence = "Hello,there,everybody,from,planet,earth!";
// you can pass an array into split. 
char[] delims = { ','    ,     ' ' };
words = sentence.Split(delims);
foreach (string word in words)
{
    Console.WriteLine(word);
}

// Let's join these words back together

sentence = string.Join('-', words);

Console.WriteLine(sentence);

// Now let's try joining with a space

sentence = string.Join(' ', words);
Console.WriteLine(sentence);

// Let's find the positiong of a letter in a string 
// IndexOf uses a common approach: It returns a 0-based index, or a -1 if it doesn't find it. 


Console.WriteLine();
Console.WriteLine("IndexOf Practice");
sentence = "We will find a letter position";
Console.WriteLine(sentence.IndexOf('i'));
Console.WriteLine(sentence.IndexOf('x'));
Console.WriteLine(sentence.LastIndexOf('i'));
Console.WriteLine(sentence.LastIndexOf('x'));

// Let's use Substring to finda piece of a string 

Console.WriteLine();
Console.WriteLine("Substring practice");
sentence = "hello world";
Console.WriteLine(sentence.Substring(1));       // Expect ello world
Console.WriteLine(sentence.Substring(3));       // Expect lo world
Console.WriteLine(sentence.Substring(4, 2));    // Expect o w