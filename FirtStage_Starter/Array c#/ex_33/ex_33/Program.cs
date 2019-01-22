using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_32
{
    class Program
    {
        //Տրված են X իրական և N բնական թվերը։ Գտնել 1 + X + X2/(2!) + … + XN/(N!) 
        //արտահայտության արժեքը (N! = 1·2·…·N)։
        /// <summary>
        /// Return Sum of Sequence 1 + X + X2/(2!) + … + XN/(N!)
        /// </summary>
        /// <param name="X">double</param>
        /// <param name="N">int</param>
        /// <returns></returns>
        static double SequenseSum(double X, int N)
        {
            double sum = 1;
            double index = 1;
            for (int i = 1; i <= N; i++)
            {
                index *= X / (double)(i);
                sum += index;

            }
            return sum;
        }
        static void Main(string[] args)
        {
            double res = SequenseSum(1.5, 22);
            Console.WriteLine(res);
            Console.ReadKey();

        }
    }
}