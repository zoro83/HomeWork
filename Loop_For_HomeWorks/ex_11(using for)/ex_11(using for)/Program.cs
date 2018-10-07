using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_11_using_for_
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputNum = Console.ReadLine();
            int N = Convert.ToInt32(inputNum);
            decimal sum = 1m;
            for (int i = 1; i <= N; i++)
            {
                sum *= 1m + 1.0m * i / 10;
                Console.Write($"'{1 + 1.0 * i / 10}', ");
            }

            Console.WriteLine("\nN = {0} \n1.1 · 1.2 · 1.3 ·... (N times) = {1}", N, sum);
            Console.ReadKey();
        }
        
    }
}
