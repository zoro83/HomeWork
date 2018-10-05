using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"Select Shape \n1 - Rectangle \n2 - Square \n3 - Circle \nShape: ");
            string outArea;
                switch (Console.ReadLine())
            {   case "1": Console.Write($"Enter Rectangle Sides \nSide A = \n{Console.ReadLine()}");
                    outArea = $"Rectangle Area is egal to {Convert.ToDouble(Console.ReadLine()) * (Convert.ToDouble(Console.ReadLine()))}"; break;
                case "2": Console.WriteLine("Enter Square Side");
                    outArea = $"Square Area is egal to {Math.Pow(Convert.ToDouble(Console.ReadLine()),2)}"; break;
                case "3": Console.WriteLine("Enter Circle Radius");
                    outArea = $"Circle Area is egal to {Math.PI * Math.Pow(Convert.ToDouble(Console.ReadLine()), 2)}"; break;
                default: outArea = $"Incorrect Format"; break;    }
            Console.WriteLine(outArea);
            Console.ReadKey();
        }
    }
}
