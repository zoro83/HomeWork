using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SymetricNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("This program cheked symetric numbers \nEnter number ");
           string input = Console.ReadLine();
            int num = int.Parse(input);
            int digit = input.Length;
            int i = 1;
            bool flag = false;
            while ((int)num /(int)Math.Pow(10,digit - i) % 10 == (int)num / (int)Math.Pow(10, i -1) % 10 && i <= digit / 2)
            {
                flag = true;
                i++;
            }
            Console.WriteLine(flag?$"{num} is symetric number": $"{num} is not symetric number");
            Console.ReadKey();
        }
    }
}
