using System.ComponentModel.Design;
using System.Numerics;
using System.Threading.Channels;

namespace Number_elevation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Hello, World!, what number would you like to elevate?");
            n = Convert.ToInt32(Console.ReadLine());
            int n1;
            Console.WriteLine("Would you like to power that by what? ");
            n1 = Convert.ToInt32(Console.ReadLine());
            var repeats = n1;
            Console.WriteLine("Resultado is " + pow(n, n1));
        }

        public static int pow(int n, int n1)
        {
            if (n1 == 0)
            {
                return 1;
            }
            else
            {
                return n * pow(n, n1 - 1);
            }
        }
    }
}