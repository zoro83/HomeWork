using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_19
{
    class Program
    {
        /// <summary>
        /// print sum of even digit an integer number less than param2
        /// </summary>
        /// <param name="num"></param>
        /// <param name="minodd"></param>
        static void SumOfEvenDigitLessParam2(long num, byte maxEven)
        {
            long fixNum = num;
            num = Math.Abs(num);
            int evenSum = 0;
            while (num != 0)
            {
                byte digit = Convert.ToByte(num % 10);
                if (digit < maxEven && digit % 2 == 0)
                {
                    evenSum += digit;
                    //Console.WriteLine(evenSum);

                }
                num /= 10;

            }
            Console.WriteLine("Sum of the even digit < {1} of number {0} is equal {2}", fixNum, maxEven, evenSum);

        }
        static void Main(string[] args)
        {
            Console.Write("Enter integer number for some operation \nn = ");
            long n = Convert.ToInt64(Console.ReadLine());
            SumOfEvenDigitLessParam2(n, 7);

            Console.ReadKey();
        }
    }
}
