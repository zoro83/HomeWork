using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_9_13_While_
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 0;
            N = Convert.ToInt32(Console.ReadLine());
            float sum = 0f;
            int i = 1;
            while (i <= N)
            {
                sum += 1.0f / i;
                i++;
            }
            Console.WriteLine("N = {0} \n1 + 1/2 + 1/3 + … + 1/N = {1}", N, sum); // ex_9
            //**************************************
            i = 0;
            long sum_2 = 0;
            while (i <= N)
            {
                sum_2 += (long)Math.Pow(N + i, 2);
                i++;
            }
            Console.WriteLine("N = {0} \nN^2 + (N + 1)^2 + (N + 2)^2 + … + (2·N)^2 = {1}", N, sum_2); //ex_10
            //*******************************************
            sum = 1f;
            i = 1;
            while (i <= N)
            {
                sum *= 1f + 1.0f * i / 10;
                i++;
            }
            Console.WriteLine("N = {0} \n1.1 · 1.2 · 1.3 ·... (N times) = {1}", N, sum); //ex_11
            //************************************************
            sum = 1f;
            i = 1;
            while (i <= N)
            {
                sum += (1f + 1.0f * i / 10)*(float)Math.Pow(-1, i + 1);
                i++;
            }
            Console.WriteLine("N = {0} \n1.1 - 1.2 + 1.3 -... (N times) = {1}", N, sum); //ex_12
            //*********************************************************
            sum_2 = 0;
            i = 1;
            while (i <= (2 * N -1))
            {
                sum_2 += i * 2 - 1;
                Console.Write("\n{0}^2 = {1}", i, sum_2);
                i++;
            } //ex_13

            Console.ReadKey();

        }
    }
}
