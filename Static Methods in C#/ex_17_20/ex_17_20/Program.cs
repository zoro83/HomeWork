using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_17_20
{
    class Program
    {
        /// <summary>
        /// Returns the minimum digit of an integer
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        static int MinDigit(int n)
        {
            n = (int)Math.Abs(n);
            int minCharacter = 0;
            int N = Convert.ToString(n).Length;
            int iDigit = 0;
            bool flag = true;
            for (int i = 0; i < 10;)
            {

                for (int j = 0; j < N; j++)
                {
                    iDigit = n / (int)Math.Pow(10, j) % 10;
                    if (iDigit == i && flag == true)
                    {
                        minCharacter = i;
                        flag = false;
                        break;
                    }
                    else
                    {
                        j++;
                    }
                    if (!flag)
                    {
                        break;
                    }
                }
                //Console.WriteLine(minCharacter);
                if (!flag)
                {
                    break;
                }

                i++;

            }
            return minCharacter;
        }
        // *****************************
        /// <summary>
        /// Returns the maximum digit of an integer
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        static int MaxDigit(int n)
        {
            n = (int)Math.Abs(n);
            int maxCharacter = 9;
            int N = Convert.ToString(n).Length;
            int iDigit = 0;
            bool flag = true;
            for (int i = 9; i >= 0;)
            {

                for (int j = 0; j < N; j++)
                {
                    iDigit = n / (int)Math.Pow(10, j) % 10;
                    if (iDigit == i && flag == true)
                    {
                        maxCharacter = i;
                        flag = false;
                        break;
                    }
                    else
                    {
                        j++;
                    }
                    if (!flag)
                    {
                        break;
                    }
                }
                //Console.WriteLine(minCharacter);
                if (!flag)
                {
                    break;
                }

                i--;

            }
            return maxCharacter;
        }
        //******************************
        /// <summary>
        /// output Maximum digit of number
        /// output Minimum digit of number
        /// Calculate Math.Pow(maxDigit - minDigit, 2)
        /// </summary>
        /// <param name="n"></param>
        static void MaxMinDifferenceSquare(int n)
        {
            int minDigit = MinDigit(n);
            int maxDigit = MaxDigit(n);
            int result = (int)Math.Pow(maxDigit - minDigit, 2);
            Console.WriteLine("Maximum digit is equal {0}", maxDigit);
            Console.WriteLine("Minimum digit is equal {0}", minDigit);
            Console.WriteLine($"({maxDigit} - {minDigit})^2 = {result}");
        }
        //***************************************8
       static int GetMinOddDigit(int num)
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
                Console.WriteLine(min);
            }
            Console.WriteLine(min);
            return min;
        }

    
        static void Main(string[] args)
        {
            Console.Write("Enter integer number for some operation \nn = ");
            int n = int.Parse(Console.ReadLine());
            MaxMinDifferenceSquare(n);
            GetMinOddDigit(n);

            Console.ReadKey();
        }
    }
}
