using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_9_using_for_
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 0;
            N = Convert.ToInt32(Console.ReadLine());
            float sum = 0f;
            if (N > 0)
            {
                for (int i = 1; i <= N; i++)
                {
                    sum += 1.0f / i;
                }
                Console.WriteLine("N = {0} \n1 + 1/2 + 1/3 + … + 1/N = {1}", N, sum);
            }
            else {
                Console.WriteLine("Incorrect number");
            }            
            Console.ReadKey();
        }
    }
}
