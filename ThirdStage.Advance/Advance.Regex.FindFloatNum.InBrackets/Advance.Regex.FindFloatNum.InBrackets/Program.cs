using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Advance.FindFloatNum.InBrackets
{
    class Program
    {
        public static void FindFloatNumInBrackets(string str)
        {
            string pattern = @"[(]\d+\.?\d+[)]|[{]\d+.?\d+[}]|[[]\d+.?\d+[]]|[<]\d+.?\d+[>]";
            Regex rx = new Regex(pattern);
            MatchCollection match = rx.Matches(str);
            foreach (var item in match)
            {
                Console.WriteLine(item.ToString()); 
            }
        }
        static void Main(string[] args)
        {
            string str = "fkkl990.88jk  (abcd3.999)kl mn [3.3 = 9.99 - 6.6] is <7 - 9.8> (44.444).99 {7.7}ol/;;p9.9";
            Console.WriteLine(str);
            FindFloatNumInBrackets(str);
            Console.ReadKey();
        } 
    }
}
