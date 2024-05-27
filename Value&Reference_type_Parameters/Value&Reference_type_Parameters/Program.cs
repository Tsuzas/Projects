using System.Numerics;

int a = 3;
int b = 4;
int c = 0;

Multiply(a, b, c);
    Console.WriteLine($"Global Statement: {a} x {b} = {c}");

void Multiply(int a, int b, int c)
{
    c = a*b;
    Console.WriteLine($"Inside Multiply Method: {a} x {b} * {c}");
}


int[] array = { 1, 2, 3, 4, 5 };

PrintArray(array);
Clear(array);
PrintArray(array);

void PrintArray(int[] array)
{
    foreach (int i in array)
    {
        Console.Write($"{i} ");
    }
    Console.WriteLine();
}

void Clear(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = 0;
    }
}
