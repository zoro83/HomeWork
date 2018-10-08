using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_4_5_while_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input n integer number \nn = ");
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            long sum = 0;
            int i = 1;
            while (i < 10)
            {
                sum = (long)Math.Pow(n, i);
                Console.Write($"'{sum}', "); //ex_4
                i++;
            }
            //ex_5
            i = 0;
            sum = 0;
            while (i <= n)
            {
                sum += i;
                i += 2;
            }
            Console.WriteLine($"\n'{sum}', ");

            Console.ReadKey();
        }
    }
}
