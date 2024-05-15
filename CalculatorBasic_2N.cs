

Console.WriteLine("Welcome to the famosa calculadora ");

    Console.WriteLine(" Please choose the first number");
        string num1 = Console.ReadLine();

    Console.WriteLine(" Now choose the funny symbol, i forgor the name of the thingy");  
        string symb1 = Console.ReadLine();
    Console.WriteLine(" Please choose the second number");
        string num2 = Console.ReadLine();

    int num1Int = int.Parse(num1);
    int num2Int = int.Parse(num2);
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
    }

    Console.WriteLine("The result is: " + result);

