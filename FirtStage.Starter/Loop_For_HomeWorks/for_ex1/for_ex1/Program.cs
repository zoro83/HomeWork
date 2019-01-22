using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            int k;
            int n;
            Console.Write("Input integer k and n (n > 0) \nk = ");
            k = Convert.ToInt32(Console.ReadLine());
            Console.Write("n = ");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++) {
                Console.Write("k  ");
            }

            Console.ReadKey();

        }
    }
}
