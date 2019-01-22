using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_14
{
    class Program
    {
        static int SumOfDigits(int n)
        {
            int N = Convert.ToString(n).Length;
            int sum = 0;
            int i = 1;
            while (i <= N)
            {
                sum = sum + n / (int)Math.Pow(10, i - 1) % 10;
                i++;
            }
            return sum;
        }
        static void Main(string[] args)
        {

            for (int i = 10; i < 100000; i++)
            {
                if (i == 2 * SumOfDigits(i))
                {
                    Console.WriteLine($"{i} is equal 2 times sum of digits");
                }
              
            }
            Console.ReadKey();
        }
    }
}
