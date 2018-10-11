using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_18
{
    class Program
    {
        /// <summary>
        /// print sum of odd digit an integer number
        /// </summary>
        /// <param name="num"></param>
        /// <param name="minodd"></param>
        static void SumOfOddDigitGreaterParam2(long num, byte minOdd)
        {
            long fixNum = num;
            num = Math.Abs(num);
            int oddSum = 0;
            while (num != 0)
            {
                byte digit = Convert.ToByte(num % 10);
                if (digit > minOdd && digit % 2 != 0)
                {
                    oddSum += digit;
                    //Console.WriteLine(oddSum);
                   
                }
                num /= 10;

            }
            Console.WriteLine("Sum of the odd digit > {1} of number {0} is equal {2}", fixNum, minOdd, oddSum);

        }
        static void Main(string[] args)
        {
            Console.Write("Enter integer number for some operation \nn = ");
            long n = Convert.ToInt64(Console.ReadLine());
            SumOfOddDigitGreaterParam2(n,4);

            Console.ReadKey();
        }
    }
}
