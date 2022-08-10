Console.WriteLine("Hello");
Console.WriteLine(10);

Add(5.5, 2.2);
int sum1 = Add(5, 3);
Console.WriteLine(sum1);




static int Add(int x, int y)
{
    return x + y;
}

static  double Add(int x, int y)
{
    return x + y;
}


// didn't work in main class. 
// probably have to call from another class

