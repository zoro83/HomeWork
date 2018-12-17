using print = System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System;

namespace ListTest
{
    public static class StringExtension
    {
        public static int WordCount(this string str, char c) //Extension
        {
            int counter = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == c)
                    counter++;
            }
            return counter;
        }
    }
    class Person
    {
        public string Name;
        public int Age;
    }
    class Program
    {
        static void Main(string[] args)
        {
            //print.WriteLine("Hello");
            //Write("World\n");
            //string str = "For simple testing";
            //int i = str.WordCount('t');
            //WriteLine(i);
            ////string myString = "hi";
            ////myString[0] = "s"; // cannot be assigned to --it is read only
            ////------------------------------------------------------
            //int? z1 = 5;
            //bool? enabled1 = null;
            //double? d1 = 3.3;

            //Nullable<int> z2 = 5;
            //Nullable<bool> enabled2 = null;
            //Nullable<System.Double> d2 = 3.3;
            //if (z2.HasValue)
            //{
            //    z2 = 7;
            //}
            //else z2 = null;
            //int? zw = z2.HasValue ? z2 : null;
            ////---------------------------------
            //string s = null;
            //string result = s ?? string.Empty;//"" or null

            //int? k = null;
            //double? d = null;

            //if (d == k)
            //{
            //    Console.WriteLine("if");
            //}
            //else
            //{
            //    Console.WriteLine("else");
            //}
            Person[] personList = new Person[]
            {
                 new Person { Name = "Bill", Age = 33 },
                 new Person { Name = "Smith", Age = 44 },
                 new Person { Name = "Bell", Age = 22 },
                 new Person { Name = "John", Age = 33 },
                 new Person { Name = "Kime", Age = 11 },
                 new Person { Name = "Haso", Age = 55 },
            };

            var pers1 = from t in personList
                        where t.Age > 25
                        orderby t.Name
                        orderby t.Age
                        select t;
            foreach (var item in pers1)
            {
                print.WriteLine(item.Age);
                print.WriteLine(item.Name);
            }
            var pers2 = personList.Where(t => t.Age > 9).OrderBy(t => t.Age);
            foreach (var item in pers2)
            {
                print.WriteLine(item.Name);
                print.WriteLine(item.Age);
            }

        print.ReadKey();
        }
}
}
