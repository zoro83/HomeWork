using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    class Program
    {
        /// <summary>
        /// Adding Two Numbers " + "
        /// </summary>
        /// <param name="num1">double</param>
        /// <param name="num2">double</param>
        /// <returns></returns>
        static double Adding(double num1, double num2)
        {
            return num1 + num2;
        }
        /// <summary>
        /// Adding Two Numbers " + "
        /// </summary>
        /// <param name="num1">integer</param>
        /// <param name="num2">integer</param>
        /// <returns></returns>
        static double Adding(int num1, int num2)
        {
            return num1 + num2;
        }
        /// <summary>
        /// Difference Two Numbers " - "
        /// </summary>
        /// <param name="num1">double</param>
        /// <param name="num2">double</param>
        /// <returns></returns>
        static double Difference(double num1, double num2)
        {
            return num1 - num2;
        }
        /// <summary>
        /// Multiplying Two Numbers 
        /// </summary>" * "
        /// <param name="num1">double</param>
        /// <param name="num2">double</param>
        /// <returns></returns>
        static double Multiplying(double num1, double num2)
        {
            return num1 * num2;
        }
        /// <summary>
        /// Dividing Two Numbers " / "
        /// </summary>
        /// <param name="num1">double</param>
        /// <param name="num2">double</param>
        /// <returns></returns>
        static double Dividing(double num1, double num2)
        {
            if (num2 == 0)
            {
                DivideBy_0_Excaption();
            }
            return num1 / num2;
        }
        /// <summary>
        /// Divided by 0 excaption
        /// </summary>
        static void DivideBy_0_Excaption()
        {
            Console.Write("Dividing by Zero error: Result is ");
        }
        /// <summary>
        /// Return Arithmetic Average of Two Numbers
        /// </summary>
        /// <param name="num1">double</param>
        /// <param name="num2">double</param>
        /// <returns></returns>
        static double ArithmeticAverage(double num1, double num2)
        {
            return (num1 + num2) / 2;
        }
        /// <summary>
        /// Return Geometric Average of Two Numbers 
        /// </summary>
        /// <param name="num1">double</param>
        /// <param name="num2">double</param>
        /// <returns></returns>
        static double GeometricAverage(double num1, double num2)
        {
            if (num1 < 0 || num2 < 0)
            {
                Console.Write("Enter non-negative numbers: ");
            }
            return Math.Pow(num1 * num2, 0.5);
        }
        /// <summary>
        /// Greates Common Divisor of Two Numbers "gcd"
        /// </summary>
        /// <param name="num1">integer</param>
        /// <param name="num2">integer</param>
        /// <returns></returns>
        static int GreatesCommonDivisor(int num1, int num2)
        {
            if (num1 % num2 == 0)
            {
                return num2;
            }
            else {
                return GreatesCommonDivisor(num2, num1 % num2);
            }
        }
        /// <summary>
        /// Least Common Multiple of Two Numbers "lcm"
        /// </summary>
        /// <param name="num1">integer</param>
        /// <param name="num2">integer</param>
        /// <returns></returns>
        static int LeastCommonMultiple(int num1, int num2)
        {
            return num1 * num2 / GreatesCommonDivisor(num1, num2);
        }
        static void Main(string[] args)
        {
            int res;
            //res = Dividing(15, 33);
            //Console.WriteLine(res);
            //res = ArithmeticAverage(2.777, 5.99);
            //res = GeometricAverage(-2, 9);
            res = GreatesCommonDivisor(32, 56);
            Console.WriteLine(res);
            res = LeastCommonMultiple(32, 56);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
