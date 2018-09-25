using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDay2
{
    class Program
    {
        static void Main(string[] args)
        {

            string str1 = "Name: ";
            string str2 = "Paul";
            //float k = (x*1.0f)/y;
            //Operations with string 
            Console.WriteLine(str1 + str2 + " " + "Smith");

            //Operations with float, double, decimal they are all not zero
            float e = 1;
            float g = 3;
            double d = 1;
            double f = 3;
            decimal h = 1;
            decimal i = 3;
            float j = 1.44f;
            double k = 1.3333333d;

            Console.WriteLine($"float {e / g}");
            Console.WriteLine($"double {d / f}");
            Console.WriteLine($"decimal {h / i}");
            Console.WriteLine($"float/decimal {j / k}");
            Console.WriteLine($"float e + g= {e + g}");
            Console.WriteLine($"float e - g= {e - g}");
            Console.WriteLine($"float e * g= {e * g}");

            int w = -1678;
            int x = 88;

            Console.WriteLine($"int w+x={w + x}");
            Console.WriteLine($"int w-x={w - x}");
            Console.WriteLine($"int w*x={w * x}");
            if (x == 0)
            {
                Console.WriteLine("Divided by 0 exception");
            }
            else
            {
                Console.WriteLine($"int w/x={w / x}");
            }
            char symb1 = '&';
            char symb2 = '%';
            Console.WriteLine(symb1 + symb2); // ??
            Console.WriteLine(symb1 - symb2); // ??
            Console.WriteLine(symb1 * symb2); // ??
            Console.WriteLine(symb1 / symb2); // ??

            bool true_ = true;
            bool false_ = false;

            Console.WriteLine("1+1=2 " + true_);
            Console.WriteLine("1+1=1 " + false_);
            Console.ReadKey();
        }
    }
}
