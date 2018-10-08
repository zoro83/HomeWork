using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_6_7_8_While_
{
    class Program
    {
        static void Main(string[] args)
        {
            int A;
            int B;
            Console.Write("Input A and B (A < B) integer numbers \nA = ");
            A = Convert.ToInt32(Console.ReadLine());
            Console.Write("B = ");
            B = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            int sum = 0;
            string multiplyBy3 = " ";
            bool flag = true;
            i = A;
            while (i>=A && i<=B)
            {
                sum += i;
                Console.Write($"'{i}', ");
                i++;
            }
            Console.WriteLine("\nSum = {0}, count = {1}", sum,B - A +1);
            i = A;
            while (i % 3 != 0 && i <= B)
            {
                i++;
            }
            Console.WriteLine("first divider by 3 is {0}",i);
            Console.ReadKey();
        }
    }
}
