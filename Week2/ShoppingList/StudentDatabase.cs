/*
                STUDENT DATABASE

*/


Console.WriteLine("Welcome to our student database!");
// TODO: Create three arrays and fill them with student info--one for name, hometown, and favorite food
string[] names =    { "Feras", "Al", "Brynn", "Jesse", "Fidan", "Sarah", "Eddie" };
string[] foods =     { "pineapple", "chips", "oranges", "pad thai", "doner", "mangos", "alfredo" };
string[] hometowns = { "Hamtramck", "Novi", "Wyandotte", "Trenton", "Troy", "Grosse Isle", "Warren" };


do
{

    bool wantList = true;
    while (wantList)
    {

        Console.WriteLine("Would you like to see a list? (y/n)");

        string entry = Console.ReadLine();
        entry = entry.ToLower();

        if (entry == "y")
        {
            for (int index = 0; index < names.Length; index++)
            {
                Console.WriteLine($" {index + 1}: {names[index]}");
            }
            wantList = false;

        }
        else if (entry == "n")
        {
            wantList = false;
        }
        else
        {
            Console.WriteLine("Please enter y or n");
        }
    } // made a list option that validates for y or n

    // TODO: Prompt the user to ask about a particular student by number. 
    Console.WriteLine("Which student would you like to learn more about? Enter 1-7:  ");

    // TODO: Convert the input to an integer. Use the integer as the index for the arrays. Print the student’s name.
    int userInput = 0;
    bool validInput = false;
    while (!validInput)
    {
        userInput = Convert.ToInt32(Console.ReadLine());


        if (userInput > 1 && userInput < 8)
        {
            Console.WriteLine($"Student {userInput} is {names[userInput - 1]}");
            validInput = true;
        }

        else
        {
            Console.WriteLine("Oops, you entered an invalid number. Try again!");
            validInput = false;
        }


    }


    // TODO:  Ask the user which category to display: Hometown or Favorite food. Then display the relevant information.
    Console.WriteLine("What would you like to know? Enter \"hometown\" or \"favorite food\" : ");

    bool validInput2 = false;
    while (!validInput2)
    {

        string userInput2 = Console.ReadLine().ToLower();

        if (userInput2 == "hometown")
        {
            Console.WriteLine($"Student {names[userInput - 1]} is from {hometowns[userInput - 1]}");
            validInput2 = true;
        }
        else if (userInput2 == "favorite food")
        {
            Console.WriteLine($"Student {names[userInput - 1]} favorite food is {foods[userInput - 1]}");
            validInput2 = true;
        }
        else
        {
            Console.WriteLine("Oops...please enter \"hometown\" or \"favorite food\"!");
            validInput2 = false;
        }

    }

    // TODO: ask if they would like to go again
   
} while (KeepGoing());



static bool KeepGoing()
{

    while (true)
    {
        // Print out message asking if user wants to continue
        Console.WriteLine("Would you like to learn about another student? (y/n)");
        // Ask the user for their input
        string response = Console.ReadLine();
        response = response.ToLower();
        // Check if they typed "y". If so, return true.
        // Otherwise return false.   YES   yes
        if (response == "y" || response == "yes")
        {
            return true;
        }
        else if (response == "n" || response == "no")
        {
            return false;
        }
        else
        {
            Console.WriteLine("Please enter y or n");
        }
    }
}

