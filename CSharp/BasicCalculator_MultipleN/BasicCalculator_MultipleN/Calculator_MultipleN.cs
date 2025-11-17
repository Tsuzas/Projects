Console.WriteLine("Welcome to the famous calculator!");

// Ask the user to input numbers
Console.WriteLine("Enter numbers separated by spaces:");
string input = Console.ReadLine();
Console.Beep();

// Ask the user to input Symbol
Console.WriteLine("Enter the funny symbol:");
string symb1 = Console.ReadLine();
Console.Beep();

// Split the input string by spaces to get individual numbers
string[] numbersAsString = input.Split(' ');

// Convert string numbers to integers and store them in an array
int[] numbers = new int[numbersAsString.Length];
for (int i = 0; i < numbersAsString.Length; i++)
{
    numbers[i] = int.Parse(numbersAsString[i]);
}

// Perform calculations
int result = numbers[0];
    switch (symb1)
     {
        case "+":
            foreach  (int num in numbers)
            {
                result += num;
            }
            break;
        case "-":
            for (int i = 1; i < numbers.Length; i++)
        {
                result -= numbers[i];
            }
            break;
        case "*":
            for (int i = 1; i < numbers.Length; i++)
            result *= numbers[i];
            break;
        case "/":
            for (int i = 1; i < numbers.Length; i++)
            result /= numbers[i];
            break;
        }

// Display the result
Console.WriteLine("Result: " + result);







