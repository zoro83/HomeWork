using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_2_While_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input n 1 digit number \nn = ");
            int n = 0;
            n = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            int sum = 0;
            //ex_3
            while (i <= n && n / 10 == 0)
            {
                sum += i;
                i++;
            }
            Console.WriteLine((n>=0)? $"{sum}":"incorrect format");
            //ex_4

            Console.ReadKey();
        }
    }
}
