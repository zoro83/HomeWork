using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_35
{
    class Program
    {
        //Խնդիր_35:
        //Տրված են X իրական և N բնական թվերը։ Գտնել 1 – X2/(2!) + X4/(4!) – … + (–1)N·X2·N/((2·N)!) 
        //արտահայտության արժեքը(N! = 1·2·…·N)։ Ստացված թիվը cos(X)-ի մոտավոր արժեքն է։
        /// <summary>
        /// cos(X) = 1 – X2/(2!) + X4/(4!) – … + (–1)N·X2·N/((2·N)!) 
        /// </summary>
        /// <param name="X">double</param>
        /// <param name="N">int</param>
        /// <returns></returns>
        static double Cos(double X, int N)
        {
            double tempN = 1;
            double sum = 1;
            for (int i = 1; i <= N; i++)
            {
                tempN *= 1.0 / (double)((2 * i) * (2 * i - 1));

                sum = sum + Math.Pow(-1, i) * Math.Pow(X, 2 * i) * tempN;

            }
            return sum;
        }
        //Խնդիր_34:
        //Տրված են X իրական և N բնական թվերը։ Գտնել X – X3/(3!) + X5/(5!) – … + (–1)N·X2·N+1/((2·N+1)!) 
        //արտահայտության արժեքը(N! = 1·2·…·N)։ Ստացված թիվը sin(X)-ի մոտավոր արժեքն է։
        /// <summary>
        /// sin(X) = X – X3/(3!) + X5/(5!) – … + (–1)N·X2·N+1/((2·N+1)!)
        /// </summary>
        /// <param name="X"></param>
        /// <param name="N"></param>
        /// <returns></returns>
        static double Sin(double X, int N)
        {
            double tempN = 1;
            double sum = X;
            for (int i = 1; i <= N; i++)
            {
                tempN *= 1.0 / (double)((2 * i + 1) * (2 * i));

                sum = sum + Math.Pow(-1, i) * Math.Pow(X, 2 * i + 1) * tempN;
            }
            return sum;
        }

        static void Main(string[] args)
        {
            double cosinus = Cos(1, 9999);
            Console.WriteLine("Cos(x) = {0}", cosinus);
            double sinus = Sin(1, 9999);
            Console.WriteLine("Sin(x) = {0}", sinus);
            double res = Math.Pow(cosinus, 2) + Math.Pow(sinus, 2);
            Console.WriteLine(res);


            Console.ReadKey();
        }
    }
}
