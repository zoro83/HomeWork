using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_12_using_for_
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            double sum = 1;
            for (int i = 1; i <= N; i++)
            {
                sum += (1 + 1.0 * i / 10) * Math.Pow(-1, i+1);
                //Console.WriteLine(sum);
                Console.Write($"'{(1 + 1.0 * i / 10) * Math.Pow(-1, i + 1)}', ");
            }
            Console.WriteLine("\nN = {0} \n1.1 – 1.2 + 1.3 – … (N times) = {1}", N, sum);
            Console.ReadKey();
        }
    }
}
