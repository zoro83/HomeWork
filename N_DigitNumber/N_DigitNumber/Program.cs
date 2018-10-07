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
            Console.Write("***\tThis program calculates the sum of N digits\t***\nInput N = ");
            string inputNum = Console.ReadLine();
            long N = inputNum.Length;
            long number = Convert.ToInt64(inputNum);
            //Console.WriteLine(N);
            if (N > 1)
            {                
                long sum = 0;
                long signed1stNum = number / ((long)Math.Pow(10, N - 2)) % 10; // if number < 0
                long unsigned2ndNum = Math.Abs(number / ((long)Math.Pow(10, N - 1)) % 10);
                //33char q = Convert.ToChar(Console.ReadKey());

                for (int i = 0; i < N - 2; i++)
                {
                    sum += Math.Abs(number / ((long)Math.Pow(10, i)) % 10);
                    //Console.Write($"'{Math.Abs(number / ((int)Math.Pow(10, N - 1 - i)) % 10)}', ");
                }
                Console.WriteLine($"Sum of digits = {(number >= 0 ? sum + signed1stNum + unsigned2ndNum : sum + signed1stNum)}");
            }
            else
            {
                Console.WriteLine(number);
            }
            // verevi for @ haskanalu hamar petq e nerqevi for er@ nayel
            //if (number >= 0)
            //{
            //    for (int i = 0; i < N; i++)
            //    {
            //        sum += Math.Abs(number / ((int)Math.Pow(10, i)) % 10);
            //        Console.Write($"'{Math.Abs(number / ((int)Math.Pow(10, N - 1 - i)) % 10)}', ");
            //    }
            //}
            //else {
            //    for (int i = 0; i < N - 2; i++) {
            //        sum += Math.Abs(number / ((int)Math.Pow(10, i)) % 10);
            //        Console.Write($"'{Math.Abs(number / ((int)Math.Pow(10, N - 1 - i)) % 10)}', ");
            //    }

            //int signed1stNum = number / ((int)Math.Pow(10, N - 2)) % 10;
            //Console.WriteLine(signed1stNum);

            //Console.WriteLine(number >= 0? sum: sum+signed1stNum );            
            Console.WriteLine(a);
            Console.ReadKey();


        }
    }
}
