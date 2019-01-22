using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input n integer number \nn = ");
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine($"n^{i} = {Math.Pow(n, i)}");
            }

            Console.ReadKey();

        }
    }
}
