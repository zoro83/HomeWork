using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_20
{
    class Program
    {
        /// <summary>
        /// Returns the minimum digit of an integer
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        static int GetMinDigit(int num)
        {
            int min = 10;
            while (num != 0)
            {
                int digit = num % 10;
                if (digit < min)
                {
                    min = digit;
                }
                num = num / 10;
                if (min == 0)
                {
                    break;
                }
                //Console.WriteLine(min);
            }
            Console.WriteLine(min);
            return min;
        }
        //*************************
        /// <summary>
        /// Returns the maximum digit of an integer
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        static int GetMaxDigit(int num)
        {
            int max = 0;
            while (num != 0)
            {
                int digit = num % 10;
                if (digit > max)
                {
                    max = digit;
                }
                num = num / 10;
                if (max == 9)
                {
                    break;
                }
                //Console.WriteLine(min);
            }
            //Console.WriteLine(max);
            return max;
        }
        //*********************
        /// <summary>
        /// output Maximum digit of number
        /// output Minimum digit of number
        /// Calculate Math.Pow(maxDigit - minDigit, 2)
        /// </summary>
        /// <param name="n"></param>
        static void MaxMinDifferenceSquare(int n)
        {
            int minDigit = GetMinDigit(n);
            int maxDigit = GetMaxDigit(n);
            int result = (int)Math.Pow(maxDigit - minDigit, 2);
            Console.WriteLine("Maximum digit is equal {0}", maxDigit);
            Console.WriteLine("Minimum digit is equal {0}", minDigit);
            Console.WriteLine($"({maxDigit} - {minDigit})^2 = {result}");
        }

        static void Main(string[] args)
        {
            Console.Write("Enter integer number for some operation \nn = ");
            int n = int.Parse(Console.ReadLine());
            MaxMinDifferenceSquare(n);

            Console.ReadKey();
        }
    }
}
