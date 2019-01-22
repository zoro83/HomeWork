using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_1_while_
{
    class Program
    {
        static void Main(string[] args)
        {
            int k;
            int n = 0;
            Console.Write("Input integer k and n (n > 0) \nk = ");
            k = Convert.ToInt32(Console.ReadLine());
            Console.Write("n = ");
            n = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            while (i < n)
            {
                Console.WriteLine(k);
                i++;
            }
            Console.ReadKey();
        }
    }
}
