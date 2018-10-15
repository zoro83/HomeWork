using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci__number
{
    class Program
    {
        /// <summary>
        /// Return N-th number for Fibonacci
        /// Fibonacci number 1,1,2,3,5,8,13,21,34,...(n-1)+(n-2)
        /// </summary>
        /// <param name="index">0,1,2,3,...</param>
        /// <returns>int index</returns>
        static int FibonacciNumber(int index)
        {
            if (index <= 1)
            {
                return 1;
            }
            return FibonacciNumber(index - 1) + FibonacciNumber(index - 2);

        }
        static void Main(string[] args)
        {
            Console.Write("Enter index of Fibbonacci number \nIndex = ");
            int N = byte.Parse(Console.ReadLine());
            Console.WriteLine("{0}-Fibonacci number is {1}", N, FibonacciNumber(N));
            Console.ReadKey();

        }
    }
}
