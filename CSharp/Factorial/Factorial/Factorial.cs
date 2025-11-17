/*



int[] num = new int[101];

Console.WriteLine("Factorial will start soon");
    Console.WriteLine("Press any key to start");
        Console.ReadLine();

var n = 101;
var n1 = 0;



System.Timers.Timer myTimer = new System.Timers.Timer(100);
myTimer.Elapsed += (sender, e) =>


{
    while (n != 1)
    {
        n = n - 1;
        Console.WriteLine(n);
        while (n != 0)
        {
           n1 = n * (n - 1);  
        };
         Console.WriteLine(n1 = n * (n - 1));
        n = 
    }
    
        Console.WriteLine("Happy factorial noises");
        Environment.Exit(0);
    
};
    myTimer.Start();
    Console.ReadKey();

    num[num.Length - 1]++;
    Console.WriteLine(num[num.Length - 1]);
 */

class Factorial
{ 
    static void Main(string[]args)
    {
        int n;
        Console.WriteLine("Choose your number");
        n=Convert.ToInt32(Console.ReadLine());
        if (n < 0)

            Console.WriteLine("Can not calculate that factorial");

        else Console.WriteLine("The factorial of that number is " + n + " = " +fact(n));
    }

    static long fact (int x)
    {

        if (x == 0) return 1;
        else return x * fact(x - 1);

}
}