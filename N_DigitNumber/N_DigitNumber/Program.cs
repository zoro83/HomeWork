using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_DigitNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program calculates the sum of N digits");
            string inputNum = Console.ReadLine();
            int N = inputNum.Length;
            Console.WriteLine(N);
            int number = Convert.ToInt32(inputNum);            
            int sum = 0;
            int signed1stNum = number / ((int)Math.Pow(10, N - 2)) % 10;
            int unsigned2ndNum = Math.Abs(number / ((int)Math.Pow(10, N - 1)) % 10);
            if (number >= 0)
            {
                for (int i = 0; i < N; i++)
                {
                    sum += Math.Abs(number / ((int)Math.Pow(10, i)) % 10);
                    Console.Write($"'{Math.Abs(number / ((int)Math.Pow(10, N - 1 - i)) % 10)}', ");
                }
            }
            else {
                for (int i = 0; i < N - 2; i++) {
                    sum += Math.Abs(number / ((int)Math.Pow(10, i)) % 10);
                    Console.Write($"'{Math.Abs(number / ((int)Math.Pow(10, N - 1 - i)) % 10)}', ");
                }
            }
            //int signed1stNum = number / ((int)Math.Pow(10, N - 2)) % 10;
            //Console.WriteLine(signed1stNum);
            Console.WriteLine(sum);
            //Console.WriteLine(number >= 0? sum: sum+signed1stNum );
            Console.ReadKey();
               

        }
    }
}
