using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_17
{
    class Program
    {
        /// <summary>
        /// output minimum odd digit an integer
        /// </summary>
        /// <param name="num"></param>
        static void GetMinOddDigit(long num)
        {
            int minOdd = 10;
            while (num != 0)
            {
                int digit = (int)num % 10;
                if (digit % 2 != 0 && digit < minOdd)
                {
                    minOdd = digit;
                }
                if (minOdd == 1)
                {
                    break;
                }
                num /= 10;
            }
            Console.WriteLine("Minimum odd digit is equal {0}",minOdd);
            
        }
        static void Main(string[] args)
        {
            Console.Write("Enter integer number for some operation \nn = ");
            long n = long.Parse(Console.ReadLine());
            GetMinOddDigit(n);

            Console.ReadKey();
        }
    }
}
