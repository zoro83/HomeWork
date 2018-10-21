using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_32
{
    class Program
    {
        
        static double SumOfSequence(int N)
        {
            double sum = 0;
            if (N == 0)
            {
                return sum + 1;
            }
            else
            {
                for (int i = 1; i <= N; i++)
                {
                    sum += 1.0 / (i * SumOfSequence(i - 1));
                }
            }

            return sum;
        } 
        /// <summary>
        /// e = 1 + 1/(1!) + 1/(2!) + 1/(3!) + … + 1/(N!) 
        /// </summary>
        /// <param name="N"></param>
        /// <returns></returns>
        static double SumOfSequence_(int N)
        {
            double sequenceIndex = 1;
            double sum = 0;
            double[][] jaggedSeq = new double[N][];
            for (int i = 0; i < N; i++)
            {
                jaggedSeq[i] = new double[i];
                for (int j = 0; j < jaggedSeq[i].Length; j++)
                {
                    jaggedSeq[i][j] = 1.0 / (j +1);
                    sequenceIndex *= jaggedSeq[i][j];
                }
                sum += sequenceIndex;

            }
            return sum;
        }

        static void Main(string[] args)
        {
            Console.Write("Recursion method \n1 + 1/(1!) + 1/(2!) + 1/(3!) + … + 1/(N!) = ");
            Console.WriteLine(SumOfSequence(22));
            Console.Write("Loop Method \n1 + 1/(1!) + 1/(2!) + 1/(3!) + … + 1/(N!) = ");
            Console.WriteLine(SumOfSequence_(22));
            Console.ReadKey();
        }
    }
}
