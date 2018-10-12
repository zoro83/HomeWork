using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllDivisors
{
    class Program
    {
        /// <summary>
        /// print all the divisors of the given number
        /// </summary>
        /// <param name="num"> int</param>
        static void AllnNumberDivisors(int num)
        {
            int fixNum = num;
            int sum = 0;
            int j;
            int count = 0;
            double div = 0.0;
            for (int i = 1; i <= (int)Math.Pow(num,0.5); i++)
            {
                
                if (num % i == 0)
                {
                    j = num / i;
                    if (i != j)
                    {
                        Console.WriteLine($"'{i}' '{j}'");
                        sum += i + j;
                        count += 2;
                    }
                    else {
                        Console.WriteLine($"'{i}'");
                        sum += i;
                        count += 1;

                    }
                   
                }
                
            }
            Console.WriteLine("Sum of all the divisors of the given number {0} is equal {1} ",fixNum, sum);
            Console.WriteLine("Count of all the divisors of the given number {0} is equal {1} ", fixNum, count);
            div = 1.0 * sum / count;
            Console.WriteLine($"Sum / Count is equal {div}");

        }
        static void Main(string[] args)
        {
            Console.Write("Enter integer number print all the divisors of the given number \nn = ");
            int n = int.Parse(Console.ReadLine());
            AllnNumberDivisors(n);
            Console.ReadKey();
        }
    }
}
