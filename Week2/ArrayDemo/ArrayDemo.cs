// An array is a variable that an hold a list of things 

int[] grades = { 100, 80, 100, 60, 85};

Console.WriteLine(grades[0]);
Console.WriteLine(grades[1]);
Console.WriteLine(grades[4]);

// array of strings 

string[] names = { "Fred", "Feras", "Frannie", "Ziggy", "Frank" };
Console.WriteLine(names[0]);
Console.WriteLine(names[2]);

int index = 3;

Console.WriteLine(names[index]); // sames as names[3]. expect to see Francine

Console.WriteLine();

for (int ind = 0; ind < 4; ind++)
{
    Console.WriteLine(names[ind]);
}


Console.WriteLine();
Console.WriteLine("names.Length to print out all the items of array");

for (int ind = 0; ind < names.Length; ind++)
{
    Console.WriteLine(names[ind]);
}

// Lets change one. Supose we misspelled the third name. Should be Jasmine
names[2] = "Jasmine";
Console.WriteLine();
Console.WriteLine($"We corrected the spelling of {names[2]}");

// Let's change the first grade
grades[0] = 99;
Console.WriteLine($"The first grade is now {grades[0]}");


