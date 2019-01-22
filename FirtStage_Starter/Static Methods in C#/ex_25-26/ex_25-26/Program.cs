using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_25_26
{
    class Program
    {
        //method1
        /// <summary>
        /// Output
        /// The maximum of 2 degree less than n
        /// </summary>
        /// <param name="num">int</param>
        /// <returns></returns>
        static int GetNearestLessNumber2degrees(int num) 
        {
            int i = 0;
            int min2Degree = 0;
            int max2Degree = 0;
            while (Math.Pow(2,i) <= num)
            {
                min2Degree = (int)Math.Pow(2,i);
                i ++;
            }
            //Console.WriteLine(min2Degree);
            return min2Degree;
        }
        //method2
        /// <summary>
        /// Output
        /// The minimum of 2 degree greater than n
        /// </summary>
        /// <param name="num">int</param>
        /// <returns></returns>
        static int GetNearestGreaterNumber2degrees(int num)
        {
            int i = 0;
            int max2Degree = 0;
            while (Math.Pow(2, i) <= num)
            {
                i++;
                max2Degree = (int)Math.Pow(2, i);
            }
            //Console.WriteLine(max2Degree);
            return max2Degree;
        }

        static void Main(string[] args)
        {

            Console.Write("Let's find out the nearest 2 degrees of given number  \nNumber = ");
            int n = int.Parse(Console.ReadLine());
            int min2Degrees = GetNearestLessNumber2degrees(n);
            int max2Degrees = GetNearestGreaterNumber2degrees(n);
            Console.WriteLine($"Max 2 some integer power less than {n} is equal {min2Degrees}");
            Console.WriteLine($"Min 2 some integer power greater than {n} is equal {max2Degrees}");
            Console.ReadKey();

        }
    }
}
