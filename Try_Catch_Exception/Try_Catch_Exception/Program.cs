
////////using System.Diagnostics;

////////double float1 = 3000.0;
////////double float2 = 0.0;
////////int number1 = 3000;
////////int number2 = 0;

////////try
////////{
////////    Process1();
////////}
////////catch
////////{
////////    Console.WriteLine($"caught exception:");
////////}
////////Console.WriteLine("Exit program");

////////static void Process1()
////////{
////////    try
////////    {
////////        WriteMessage();
////////    }
////////    catch (DivideByZeroException ex)
////////    {
////////        Console.WriteLine($"Exception caught in Process1: {ex.Message}");
////////    }
////////}

////////static void WriteMessage()
////////{
////////    double float1 = 3000.0;
////////    double float2 = 0.0;
////////    int number1 = 3000;
////////    int number2 = 0;
////////    byte smallNumber;

////////    Console.WriteLine(float1 / float2);
////////    Console.WriteLine(number1 / number2);
////////    checked
////////    {
////////        smallNumber= (byte)number1;
////////    }
////////}

try
{
    WriteMessage();
}
catch (OverflowException ex)
{
    Console.WriteLine("CaughtException");
}
Console.WriteLine("Exiting program.");



void WriteMessage()
{
    OverFlow();
    NullRef();
    NoRange();
    DivideZero();
}
void OverFlow()
{
    try
    {
        int num1 = int.MaxValue;
        int num2 = int.MaxValue;
        int result = num1 + num2;
        checked
        {
            result = (byte)num1;
        }
        Console.WriteLine("Result: " + result);
    }
    catch (OverflowException ex)
    {
        Console.WriteLine("Error: The number is too large to be represented as an integer." + ex.Message);

    }
}

void NullRef()
{
    try
    {
        string str = null;
        int length = str.Length;
        Console.WriteLine("String Length: " + length);
    }
    catch (NullReferenceException ex)
    {
        Console.WriteLine("Error: The reference is null." + ex.Message);
    }
    
}

void NoRange()
{
    try
    {
        int[] numbers = new int[5];
        numbers[5] = 10;
        Console.WriteLine("Number at index 5: " + numbers[5]);
    }
    catch (IndexOutOfRangeException ex)
    {
        Console.WriteLine("Error: Index out of range." + ex.Message);
    }
    
}

void DivideZero()
{
    try
    {
        int num3 = 10;
        int num4 = 0;
        int result2 = num3 / num4;
        Console.WriteLine("Result: " + result2);
    }
    catch (DivideByZeroException ex)
    {
        Console.WriteLine("Error: Cannot divide by zero." + ex.Message);
    }
}
