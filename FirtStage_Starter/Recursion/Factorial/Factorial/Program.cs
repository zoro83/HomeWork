using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        /// <summary>
        /// Return N! factorial
        /// </summary>
        /// <param name="N">1,2,3,...</param>
        /// <returns>N!</returns>
        static long Factorial(int N)
        {
            if (N == 1)
            {
                return 1;
            }
            else
            {
                return N * Factorial(N - 1);
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Enter N for counting N! \nN = ");
            int N = byte.Parse(Console.ReadLine());
            Console.WriteLine("{0}! = {1}", N, Factorial(N));

            Console.ReadKey();
        }
    }
}
