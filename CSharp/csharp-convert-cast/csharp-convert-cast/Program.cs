/*Replace the code comments in the starter code with your own code to solve the challenge:

Solve for result1: Divide value1 by value2, display the result as an int
Solve for result2: Divide value2 by value3, display the result as a decimal
Solve for result3: Divide value3 by value1, display the result as a float

 */

int value1 = 11;
decimal value2 = 6.2m;
float value3 = 4.3f;

// Your code here to set result1
// Hint: You need to round the result to nearest integer (don't just truncate)
int result1 = 0;
result1 = (int)Math.Round(value1 / value2);
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

// Your code here to set result2
decimal result2 = 0;
result2 = value2 / (decimal)value3;
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

// Your code here to set result3
float result3 = 0;
result3 = (float)value3 / (float)value1;
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");