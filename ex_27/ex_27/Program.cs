using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_27
{
    class Program
    {
        /// <summary>
        /// reversing and adding 0 between digits of number
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        static string ReversAndNullBetweenDigits(int num)
        {
            byte N = (byte)Convert.ToString(num).Length;
            string str = " ";
            byte[] digit = new byte[2 * N];
            for (byte i = 0; i < N; i ++)
            {
                digit[2 * i] = (byte)(num % 10);
                Console.Write(digit[2 * i]);
                digit[2 * i + 1] = 0;
                Console.Write(digit[2 * i + 1]);
                num /= 10;
            }

            return str;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter N for reversing and adding 0 between digits N \nN = ");
            int N = Int32.Parse(Console.ReadLine());
            ReversAndNullBetweenDigits(N);

            Console.ReadKey();
        }
    }
}
