using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binnary_to_Integer_and_vice_versa
{
    class Program
    {
        static void Main(string[] args)
        {
            string intInput = Console.ReadLine();
            int i = 0;
            int decim = int.Parse(intInput);
            i = decim;
            int bin = 0;
            while (i / 2 != 0)
            {
                bin = i % 2;
                i /= 2;
                Console.Write(bin);
            }
            Console.Write("1");
        
            
            Console.ReadKey();
        }
       
    }
}
