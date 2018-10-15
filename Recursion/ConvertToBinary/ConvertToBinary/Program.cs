using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertToBinary
{
    class Program
    {
        /// <summary>
        /// Decimal number convert to binary
        /// </summary>
        /// <param name="num">int</param>
        static void IntConvertToBinary(int num)
        {
            if (num / 2 != 0)
            {
                IntConvertToBinary(num / 2);
                Console.Write(num % 2);
            }
            else Console.Write(1);
        }
        static void Main(string[] args)
        {
            Console.Write("Enter N decimal number for convert to binary \nN = ");
            int N = int.Parse(Console.ReadLine());
            IntConvertToBinary(N);
            Console.ReadKey();
        }
    }
}
