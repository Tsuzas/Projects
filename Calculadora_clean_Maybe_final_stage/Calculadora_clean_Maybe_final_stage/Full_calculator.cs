



using System;
using System.Threading.Channels;

Console.WriteLine("Waddup this is the final stage calculadora, so I will be going all out.");
Console.WriteLine("Please choose your first number.");
    string input1 = Console.ReadLine();
Console.WriteLine("Please choose the the funny sign.");
    string symb1 = Console.ReadLine();
Console.WriteLine("Please choose the second number.");
    string input2 = Console.ReadLine();

    int num1Int = int.Parse(input1);
    int num2Int = int.Parse(input2);
    int result = 0;

    switch (symb1)
    {
        case "+":
            result = num1Int + num2Int;
            break;
        case "-":
            result = num1Int - num2Int;
            break;
        case "*":
            result = num1Int * num2Int;
            break;
        case "/":
            result = num1Int / num2Int;
            break;
        default:
            Console.WriteLine("Do you want to stop?");
            string test1 = Console.ReadLine();
            break;
}
    
    Console.WriteLine(num1Int + symb1 + num2Int + "=" + result);

var test = true;
var newResult = 0;
var input3ReTry = 0;

while (test == true)
{
    Console.WriteLine("Please add the funny symbol again");
        string symb2 = Console.ReadLine();
    Console.WriteLine("Now the other number");
        string input3 = Console.ReadLine();

    int num3Int;
    if (int.TryParse(input3, out num3Int))
        /*
        int num3Int;
        if (int.TryParse(input3, out num3Int))
        {
            Console.WriteLine("Now the other number again retarded.");
            string = Console.ReadLine();
        }
        else
            input3ReTry = num3Int;
        */

        switch (symb2)
    {
        case "+":
            newResult = result + num3Int;
            break;
        case "-":
            newResult = result - num3Int;
            break;
        case "*":
            newResult = result * num3Int;
            break;
        case "/":
            newResult = result / num3Int;
            break;
        default:
            Console.WriteLine("Do you want to stop?");
            string test1 = Console.ReadLine();
            break;
    }

     
   Console.WriteLine(result + symb2 + num3Int + "=" + newResult);
    result = newResult;
}



