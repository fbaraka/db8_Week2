// goal is to reverse a string using a stack!



// Let's take in some user input! 
Console.Write("enter a word you would like to reverse: ");
string userInput = Console.ReadLine();
Console.WriteLine("Your word reversed is: " + MakeReverse(userInput)); 


static string MakeReverse(string normalString)
{
    // initializing a stack
    Stack<char> letterStack = new Stack<char>();
    string reversed = "";
    string reversedAddition = "";
    char[] individualLetters = normalString.ToCharArray();
    for (int i = 0; i < individualLetters.Length; i++)
    {
        letterStack.Push(individualLetters[i]);
    }

    // was only getting a few letters. Realized count was changing with each pop
    // started from the length of count and incremented down to zero

    for (int i = letterStack.Count; i > 0; i--)
    {
        reversed = "" + letterStack.Pop();
        reversedAddition = reversedAddition + reversed;
    }


    return reversedAddition;
}
