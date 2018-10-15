using System;??
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial__1
{
    class Program
    {
        static long Factorial(int n)
        {
            return Factorial(n - 1) * n;

        }
        static void Main(string[] args)
        {
            Console.Write(Factorial(3));

                
        }
    }
}
