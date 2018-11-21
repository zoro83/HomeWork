using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexNumbers
{
    class Program
    {
        public static void Print(Complex num)
        {
            Console.WriteLine(num.GetValue());
        }
        static void Main(string[] args)
        {
            Complex X = new Complex(9, -2);
            Print(X);
            Complex Y = new Complex(0, 7);
            Print(Y);
            Complex Z = new Complex(-6, 0);
            Print(Z);

            X.SetValue(3, 3);
            Print(X);
            
            Z = Z.Plus(X, Y);
            Print(Z);

            Z = Z.Minus(X, Y);
            Print(Z);

            Z = Z.Multiplication(X, Y);
            Print(Z);

            Z = Z.Absalute(Z);
            Print(Z);

            Console.ReadKey();
        }
    }
}
