using System;
using System.ComponentModel.Design;
using System.Linq;
using System.Threading.Channels;

namespace Array_sum_recursive
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int[] n1 = new int[100];    // Creates an array with 100 slots all of them valued at 0
            Console.WriteLine(rec(n1));
        }

        static int rec(int[] n1)
        {
            if (n1.Length == 0)
            {
                return 0;
            }
            return n1[0] + rec(n1[1..]);
        }
    }
}

