using System.Text.RegularExpressions;

namespace Factorial_again_nocheats
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World! Hit me up with factorial funny numbers");
            int num;
            var repeat = 0;
            num = Convert.ToInt32(Console.ReadLine());
            repeat = num;
            Console.WriteLine(fact(num));
        }
        static int fact(int num)
        {
            if (num <= 1)
                return 1;
            else
                return num * fact(num- 1);
        }
    }
}
