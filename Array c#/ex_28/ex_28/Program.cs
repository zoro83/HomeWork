using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_28
{
    class Program
    {
        // Խնդիր_28:
        // Ներածել n թիվը։ Արտածել yes, եթե այն հավասար է իր թվանշանների գումարի կրկնապատիկին, no՝ հակառակ դեպքում։

        /// <summary>
        /// Return sum of digits
        /// </summary>
        /// <param name="num">int</param>
        /// <returns></returns>
        static int SumOfDigits(int num)
        {
            int sum = 0;
            byte lenght = (byte)Convert.ToString(num).Length;
            byte[] digits = new byte[lenght];
            for (int i = 0; i < digits.Length; i++)
            {
                digits[i] = Convert.ToByte(num % 10);
                sum += digits[i];
                num /= 10;
            }

            return sum;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter N for cheking \nN = ");
            int N = int.Parse(Console.ReadLine());
            string result = (N == 2 * SumOfDigits(N)) ? "Yes" : "No";
            Console.WriteLine(result);
            for (int i = 10; i < 100000; i++)
            {
                if (i == 2 * SumOfDigits(i))
                {
                    Console.WriteLine($"Example: {i} is equal 2 times sum of digits");
                }
            }
                Console.ReadKey();
        }
    }
}
