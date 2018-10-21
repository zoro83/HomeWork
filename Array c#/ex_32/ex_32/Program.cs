using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_32
{
    class Program
    {
        //Խնդիր_32:
        //Տրված է N բնական թիվը։ Օգտագործելով մեկ ցիկլ հաշվել 1 + 1/(1!) + 1/(2!) + 1/(3!) + … + 1/(N!) 
        //գումարը(N!-ով նշանակված է 1-ից N թվերի արտադրյալը։ Ստացված թիվը հանդիսանում է e հաստատունի մոտավոր արժեքը)։
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
        static double Exponential(int N)
        {
            double tempN = 1;
            double sum = 1;
            for (int i = 1; i <= N; i++)
            {
                tempN *= 1.0 / (double)(i);
                sum += tempN;
            }
            return sum;
        }

    static void Main(string[] args)
    {
        Console.Write("Recursion method \n1 + 1/(1!) + 1/(2!) + 1/(3!) + … + 1/(N!) = ");
        Console.WriteLine(SumOfSequence(22));
        Console.Write("Loop Method \n1 + 1/(1!) + 1/(2!) + 1/(3!) + … + 1/(N!) = ");
        Console.WriteLine(Exponential(22));
        Console.ReadKey();
    }
}
}
