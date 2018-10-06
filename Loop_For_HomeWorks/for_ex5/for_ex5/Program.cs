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
            // exercise 6,7,8 all together
            int A;
            int B;
            Console.Write("Input A and B (A < B) integer numbers \nA = ");
            A = Convert.ToInt32(Console.ReadLine());
            Console.Write("B = ");
            B = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            int sum = 0;
            int multiplyBy3 = 0;
            if (A < B)
            {   // start of exercise 6, 7
                for (int i = A; i <= B; i++) 
                {
                    count ++;
                    sum += i;
                    Console.WriteLine($"{i} belong to [A, B]");

                }
                Console.WriteLine($"Count of integer numbers in [A, B] segment is equal to {count}");
                // end of exercise 6
                Console.WriteLine($"Sum of integer numbers in [A, B] segment is equal to {sum}");
                // end of exercise 7
                // start of exercise 8
                for (int i = A; i <= B; i++)
                {
                    if (i % 3 == 0)
                    {
                        Console.WriteLine($"The first multiplying by 3 numbers of the [A, B] segment is equal to'{i}'");
                        break;
                    }                   
                }
                // end of exercise 8                
            }
            else {
                Console.WriteLine("Incorrect input");
            }

            Console.ReadKey();
        }
    }
}
