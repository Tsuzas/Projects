using System.Timers;

// Chat GPT Unironically spoiled me the answer :(

    int[] num = { 0, 1 };
    var result = 0;
    var test = true;

Console.WriteLine("Fibonacci Sequence starting soon");
Console.WriteLine("Press any key to start");
    Console.ReadLine();
System.Timers.Timer myTimer = new System.Timers.Timer(1000);
    myTimer.Elapsed += (sender, e) =>
    {
        result = num[0] + num[1];
        Console.WriteLine(num[0] + " + " + num[1] + " = " + result);

        num[0] = num[1];
        num[1] = result;
    };

myTimer.Start();
Console.ReadKey();

