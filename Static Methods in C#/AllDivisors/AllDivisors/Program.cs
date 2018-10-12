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
            for (int i = 1; i <= Math.Pow(num,0.5); i++)
            {
                
                if (num % i == 0)
                {
                    int j = num / i;
                    Console.WriteLine((i != j)?$"'{i}' '{j}'":$"'{i}'");
                }
                
            }


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
