using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_ex5
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
            int Sum = 0;
            if (A < B)
            {
                for (int i = A; i <= B; i++)
                {
                    Sum ++;
                    Console.WriteLine($"{i} belong to [A, B]");

                }
                Console.WriteLine($"Count integer numbers in [A, B] segment is equal to {Sum}");
            }
            else {
                Console.WriteLine("Incorrect input");
            }

            Console.ReadKey();
        }
    }
}
