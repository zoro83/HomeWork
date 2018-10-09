using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PictureApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 0; //Rhombus side
            N = Convert.ToInt32(Console.ReadLine());
            string visible = " + ";
            string unvisible = "   ";

            for (int i = 0; i < N; i = Math.Abs(i) + 1)
            {
                //Console.WriteLine();
                for (int j = 1; j <= 2 * N - 1; j++)
                {
                    Console.Write((j >= N - i && j <= N + i) ? visible : unvisible);
                    //Console.Write(delete != (2 * N - 1) / 2?"   ":str);
                    //delete++;
                }

                Console.WriteLine();
            }
                for (int p = 1; p <= N-1; p++)
                {
                    for (int k = 1; k <= 2 * N - 1; k++)
                    {
                        Console.Write((k > p && k < 2 * N - p) ? visible : unvisible);
                    }
                    Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
