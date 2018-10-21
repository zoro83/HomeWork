using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_34
{
    class Program
    {
        //Խնդիր_34:
        //Տրված են X իրական և N բնական թվերը։ Գտնել X – X3/(3!) + X5/(5!) – … + (–1)N·X2·N+1/((2·N+1)!) 
        //արտահայտության արժեքը(N! = 1·2·…·N)։ Ստացված թիվը sin(X)-ի մոտավոր արժեքն է։
        /// <summary>
        /// Sin(x) = X – X3/(3!) + X5/(5!) – … + (–1)N·X2·N+1/((2·N+1)!) 
        /// </summary>
        /// <param name="X">double</param>
        /// <param name="N">int</param>
        /// <returns></returns>
        static double sin(double X, int N)
        {
            double index = 1;
            double sum = X;
            for (int i = 1; i <= N; i += 2)
            {
                index *= Math.Pow(-1, i) * X / (double)(2 * i + 1);
                sum += index;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            double sinus = sin(1, 4455);
            Console.WriteLine(sinus);
            Console.ReadKey();
        }
    }
}
