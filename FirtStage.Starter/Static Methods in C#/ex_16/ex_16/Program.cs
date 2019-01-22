using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_16
{
    class Program
    {
        /// <summary>
        ///  returns the sum of digits of the natural number, the multiply
        ///of digits, the length of number       
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        static void ՕperationsDigitCharacters(int n)
        {
            int sumDigit = 0;
            int N = Convert.ToString(n).Length;
            int multyplyDigit = 1;
            for (int i = 1; i <= N; i++)
            {
                sumDigit += n / (int)Math.Pow(10, i - 1) % 10;
                multyplyDigit *= (int)n / (int)Math.Pow(10, i - 1) % 10;
            }
            Console.WriteLine($"Number = {n}");
            Console.WriteLine($"The sum of digit is equals {sumDigit}");
            Console.WriteLine($"The multiply of digit is equals {multyplyDigit}");
            Console.WriteLine($"The length of number is equals {N}");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter integer number");
            ՕperationsDigitCharacters(Convert.ToInt32(Console.ReadLine()));
            Console.ReadKey();
        }
    }
}
