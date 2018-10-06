using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("This program prints Fibonacci numbers \nInput count N = ");
            int N;
            N = int.Parse(Console.ReadLine());
            int x = 0;
            int y = 1;
            for (int i = 0; i < N; i ++)
            {
                int fibon = x;
                x = y;
                y = y + fibon;
                Console.WriteLine($"'{fibon}'");
            }

            Console.ReadKey();

        }
    }
}
