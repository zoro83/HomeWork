using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_36
{
    class Program
    {
        //Խնդիր_36:
        //Տրված են X իրական(|X|<1) և N բնական թվերը։ Գտնել X–X2/2 + X3/3 –…+ (–1)N–1·XN/N 
        //արտահայտության արժեքը։ Ստացված թիվը ln(1+X)-ի մոտավոր արժեքն է։
        /// <summary>
        /// ln(1+X) = X–X2/2 + X3/3 –…+ (–1)N–1·XN/N 
        /// </summary>
        /// <param name="X">double</param>
        /// <param name="N">integer</param>
        /// <returns></returns>
        static double Ln(double X, int N)
        {
            double tempN = 1;
            double sum = 0;
            for (int i = 1; i <= N; i++)
            {
                sum += -Math.Pow(-X, i) / (double)(i);
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Ln(1,3333));
            Console.ReadKey();
        }
    }
}
