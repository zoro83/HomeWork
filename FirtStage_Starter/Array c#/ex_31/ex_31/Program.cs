using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_31
{
    class Program
    {
        /// <summary>
        /// Enter 2 < N < 100 number for printing sequence
        /// </summary>
        /// <param name="n"></param>
        static void Sequence(int n)
        {
            int count = 0;
            int nextNumber = n;
            while (nextNumber != 1)
            {
                if (nextNumber % 2 == 0)
                {
                    nextNumber = nextNumber / 2;
                    count++;
                }
                else
                {
                    nextNumber = 3 * nextNumber + 1;
                    count++;
                }
                //(nextNumber % 2 == 0)?nextNumber = nextNumber/2: nextNumber = 3 * nextNumber + 1;
            }
            int[] sequence = new int[count + 1];
            sequence[0] = n;
            for (int i = 0; i < sequence.Length - 1; i++)
            {
                if (sequence[i] % 2 == 0)
                {
                    sequence[i + 1] = (sequence[i] / 2);
                }
                else
                {
                    sequence[i + 1] = (3 * sequence[i] + 1);
                }
                Console.WriteLine($"{sequence[i]}");
            }
            Console.WriteLine(1);
        }
        static void Main(string[] args)
        {
            Console.Write("Enter 2 < N < 100 number for printing sequence \nN = ");
            int N = int.Parse(Console.ReadLine());
            if (N > 2 && N < 100)
            {
                Sequence(N);
            }
            else
                Console.WriteLine("Wrong input");

            Console.ReadKey();
        }
    }
}
