// going to create 2 arrays of the same size

string[] names = { "Abdul Amin", "Barbara Baker", "Cherine Cooper", "Douglas Dickerson", "Emily Emerson" };
int[] grades = { 95, 98, 85, 80, 70 };

//Print out all the grades

for (int index = 0; index <= 4; index++)
{
    Console.WriteLine($"{names[index]} has grade {grades[index]}");
}

// Print out all the grades but slightly different for loop
// Ask the first array how long it is. It will tell us it has 5 members (or elements).
// but the bounds are 0 to 4.
// that upper bound, 4 is one less than the size of the array
Console.WriteLine();
Console.WriteLine($"There are {names.Length} students.");

for (int i = 0; i < names.Length; i++)  // Instead of index <= names.Length - 1
{
    Console.WriteLine($"{names[i]} has grade {grades[i]}");
}

//// ask the user which one to print out 
//Console.WriteLine("Please enter a number from 0 to 4.");
//string entry = Console.ReadLine();
//int num = int.Parse(entry);
//Console.WriteLine($"{names[num]} has grade {grades[num]}");

// Ask the user which one to print out, but start with 1.
// So if they type "1" we want to give them back index 0. So we need to subtract 1. 
// Version 1


//Console.WriteLine();
//Console.WriteLine("Please enter a number from 1 to 5.");
//entry = Console.ReadLine();

//num = int.Parse(entry);
//num--;  // Convert the number to an index

//Console.WriteLine($"{names[num]} has grade {grades[num]}");

// Version 2

bool okay = false;
int num = 0;

while (!okay)
{
    Console.WriteLine();
    Console.WriteLine("Please enter a number from 1 to 5.");
    string entry = Console.ReadLine();
    bool validNumber = int.TryParse(entry, out num);

    if (validNumber)
    {
        if (num >= 1 && num <= 5)
        {
            okay = true;
        }
    }
}


//  This next code will run after they have entered a valid number.
if (okay)
{
    num--;
    Console.WriteLine($"{names[num]} has grade {grades[num]}");
}




