int[] numbers = { 4, 8, 15, 16, 23, 42 };
int total = 0;
bool found  = false;

foreach (int number in numbers)
{
    total += number;

    if (number != 42)
    {
       found = true;
    }
}

if (found == true) 
{
    Console.WriteLine("Set contains 42");
    Console.WriteLine($"Total: {total}");
}
else
{
    Console.WriteLine("It does not contain");
    Console.WriteLine($"Total: {total}");
}
