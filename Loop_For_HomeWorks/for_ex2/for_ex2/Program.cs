using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input n 1 digit number \nn = ");
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            if (n >= 0 && n < 10)
            {
                for (int i = 0; i <= n; i++)
                {
                    Console.Write($"'{i}' ");
                }
            }
            else {
                Console.WriteLine("Incorrect input");
            }
            Console.ReadKey();
        }
    }
}
