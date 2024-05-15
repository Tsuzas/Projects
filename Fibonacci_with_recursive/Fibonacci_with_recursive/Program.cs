namespace Fibonacci_with_recursive
{
    internal class Program
        
    {
        static void Main(string[] args)
        {
            
            int x;
            Console.WriteLine("Fibonacci sequence starting soon. \n Escolhe ai o valor.");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(rec(x));
        }
        static long rec(int x)
        {

            if (x == 0)
            {
                Console.WriteLine("Done");
                return 0;
            }
            
            else if (x == 1)
            {
             return 1;
            }
            else 
            {
                var num0 = rec(x - 1);
                var num1 = rec(x - 2);
                long result = num0 + num1;
                return result;
            }
        }


    }
}
