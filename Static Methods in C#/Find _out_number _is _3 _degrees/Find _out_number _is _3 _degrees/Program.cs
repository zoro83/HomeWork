using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find__out_number__is__3__degrees
{
    class Program
    {
        static void Find_out_number_is_3_degrees(int num)
        {
            int i = 3;
            bool flag = true;
            while (num % i == 0)
            {
                if (num == i)
                {
                    flag = false;
                    break;
                }
                i *= 3;
            }
            Console.WriteLine((flag)?"No":"yes");
        }
        static void Main(string[] args)
        {
            Console.Write("Let's find out if the given number is 3 degrees \nNumber = ");
            int n = int.Parse(Console.ReadLine());
            Find_out_number_is_3_degrees(n);
            Console.ReadKey();
        }
    }
}
