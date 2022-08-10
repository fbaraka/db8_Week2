Stack<string> cards = new Stack<string>();

cards.Push("3D");
cards.Push("AS");
cards.Push("QH");
cards.Push("10D");

string next = cards.Pop();
Console.WriteLine(next);
Console.WriteLine(cards.Count);
Console.WriteLine();

next = cards.Pop();
Console.WriteLine(next);
Console.WriteLine(cards.Count);
Console.WriteLine();

next = cards.Pop();
Console.WriteLine(next);
Console.WriteLine(cards.Count);
Console.WriteLine();

next = cards.Pop();
Console.WriteLine(next);
Console.WriteLine(cards.Count);
Console.WriteLine();

Console.WriteLine();
Console.WriteLine("Now lets do some Queue practice");

Queue<int> nums = new Queue<int>();
nums.Enqueue(5); // 5 got there first 
nums.Enqueue(10);
nums.Enqueue(15);
nums.Enqueue(20);

Console.WriteLine(nums.Dequeue());
Console.WriteLine(nums.Count);
Console.WriteLine();

Console.WriteLine(nums.Dequeue());
Console.WriteLine(nums.Count);
Console.WriteLine();

Console.WriteLine(nums.Dequeue());
Console.WriteLine(nums.Count);
Console.WriteLine();

Console.WriteLine(nums.Dequeue());
Console.WriteLine(nums.Count);
Console.WriteLine();


// Console.WriteLine(nums.Dequeue()); // This line will throw an exception

Console.WriteLine();
Console.WriteLine("Advanced stack stuff");

cards.Clear();      // this empties out the stack it clears it 

cards.Push("5D");
cards.Push("JH");
cards.Push("3S"); // Si far we have 5d on the bottom, jh next on top, and 3s at the very top

Console.WriteLine(cards.Pop()); // expect 3S

// Let's just look at the top of the deck, but not pull it off. 
string top = cards.Peek();
Console.WriteLine($"The top is {top} but we didn't remove it.");

// We didn't remove JH, so it's still there. So the next pop will be JH
Console.WriteLine(cards.Pop()); // Expect JH

cards.Push("9H");
cards.Push("10D");
cards.Push("KS");

Console.WriteLine(cards.Pop());     // expect KS

cards.Push("5D");

// now Lets draw them all off
Console.WriteLine();
Console.WriteLine("Let's draw all the rest of the cards!");
while(cards.Count > 0)
{
    next = cards.Pop();
    Console.WriteLine($"We just drew {next}");
}

Console.WriteLine($"The count of the deck is now {cards.Count}"); // expect to see 0












