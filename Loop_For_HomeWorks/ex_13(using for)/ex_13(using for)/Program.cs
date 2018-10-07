using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_13_using_for_
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            double sum = 0;
            for (int i = 1; i <= N; i++)
            {
                sum += i * 2 - 1;
                Console.WriteLine(i!=N? $"{i}^2 = {sum}":" ");
            }
            Console.Write("Final result \n{0}^2 = {1}", N, sum);
            Console.ReadKey();
        }
    }
}
