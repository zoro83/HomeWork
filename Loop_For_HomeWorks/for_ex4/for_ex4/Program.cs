using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Input n integer number \n = ");
            n = Convert.ToInt32
                (Console.ReadLine());
            for (int i = 0; i <= n; i+=2)
            {
                Console.Write("'{0}'", i);
            }

            Console.ReadKey();
        }
    }
}
