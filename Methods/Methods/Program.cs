void sayHello()
{
    Console.WriteLine("Hello Worldies");
    Console.WriteLine();
}

void printArray()
{
    int[] a = { 1, 2, 3, 4, 5 };
    Console.WriteLine("Contents of the array: ");
    foreach (int i in a)
    {
        Console.WriteLine($"{i}");
    }
    Console.WriteLine();
}

void displayRandomNumbers()
{
    Console.WriteLine($"Generating Random Numbers: ");
    Random random = new Random();
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine($"{random.Next(1, 100)}");
    }
    Console.WriteLine();
}

    sayHello();
    printArray();
    displayRandomNumbers();
