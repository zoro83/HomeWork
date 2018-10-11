using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_15
{
    class Program
    {
        static int Remove1stDigit(int n)
        {
            int result = n % 100;
            //Console.WriteLine(result);
            return result;
        }
        static void Main(string[] args)
        {
             for (int i = 100; i < 1000; i++)
            {
                if (i == 7 * Remove1stDigit(i))
                {
                    Console.WriteLine(i);
                }
                //Console.WriteLine(Remove1stDigit(i));
            }
            Console.ReadKey();
        }
    }
}
