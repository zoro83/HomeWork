using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondStage.OOP.Operator01
{
    class Program
    {
        public static void Print(Point pnt, string str)
            => Console.WriteLine("{2} = ({0}, {1})", pnt.X, pnt.Y, str);
        static void Main(string[] args)
        {
            Point P1 = new Point(3, 4);
            Point P2 = new Point();
            P2.X = 2;
            P2.Y = 3;
            Point P3 = P1 + P2;
            Print(P3, "(3,4) + (2,3)");
            P3 = P1 - P2;
            Print(P3, "(3,4) - (2,3)");
            P3 = P1 * P2;
            Print(P3, "(3,4) * (2,3)");
            P3 = P1 / P2;
            Print(P3, "(3,4) / (2,3)");
            P3 = P1 + 4;
            Print(P3, "(3,4) + 4");
            P3++;
            Print(P3, "(7,8)++");
            P3--;
            Print(P3, "(8,9)--");
            Console.WriteLine($"(3,4) > (2,3) {P1 > P2}");

            Console.ReadKey();

        }
    }
}
