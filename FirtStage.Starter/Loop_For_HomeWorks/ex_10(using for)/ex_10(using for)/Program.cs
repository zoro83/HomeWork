using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_10_using_for_
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 0;
            N = Convert.ToInt32(Console.ReadLine());
            long sum = 0;
            for (int i = 0; i <= N; i++)
            {
                sum += Convert.ToInt64(Math.Pow((N + i), 2));
            }
            Console.WriteLine("N = {0} \nN^2 + (N + 1)^2 + (N + 2)^2 + … + (2·N)^2 = {1}", N, sum);
            Console.ReadKey();
        }
    }
}
