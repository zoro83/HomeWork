using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PositiveCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNum1;
            int inputNum2;
            string operation;

            Console.WriteLine("Enter two integer numbers");
            Console.Write("Num1 = ");
            inputNum1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Num2 = ");
            inputNum2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Select any operation ABS \n'+', '-', '*', '/', '%', 'Power', 'Square root'");
            operation = Console.ReadLine();
            //Console.WriteLine($"Num1 {operation} Num2 = {inputNum1} {operation} {inputNum2}");
            if (operation == "+") {
                Console.WriteLine($"ABS(Num1 {operation} Num2) = {Math.Abs(inputNum1 + inputNum2)}");
            }
            if (operation == "-")
            {
                Console.WriteLine($"ABS(Num1 {operation} Num2) = {Math.Abs(inputNum1 - inputNum2)}");
            }
            if (operation == "*")
            {
                Console.WriteLine($"ABS(Num1 {operation} Num2) = {Math.Abs(inputNum1 * inputNum2)}");
            }
            if (operation == "/")
            {
                if (inputNum2 != 0)
                {
                    Console.WriteLine($"ABS(Num1 {operation} Num2) = {Math.Abs((inputNum1*1.0d) / inputNum2)}");
                }
                else {
                    Console.WriteLine("Divided by 0 exception");
                }
                //Console.WriteLine($"ABS(Num1 {operation} Num2) = {Math.Abs(inputNum1 * inputNum2)}");
            }
            // Math Power
            if (operation == "Power" || operation == "power") {       // case insensitive
                Console.Write("Input Power of Num1: ");
                double powerNum1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Input Power of Num2: ");
                double powerNum2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine($"ABS(Num1)^{powerNum1}) = {Math.Abs(Math.Pow(inputNum1, powerNum1))}");
                Console.WriteLine($"ABS(Num2)^{powerNum2}) = {Math.Abs(Math.Pow(inputNum2, powerNum2))}");
            }
            // Square root
            if (operation == "Square root" || operation == "square root" || operation == "square Root" || operation == "Square Root")
            // case insensitive
            {
                Console.WriteLine($"Root of ABS(Num1) = {Math.Sqrt(Math.Abs(inputNum1 * 1.0d))}");
                Console.WriteLine($"Root of ABS(Num2) = {Math.Sqrt(Math.Abs(inputNum2 * 1.0d))}");
            }

            else {

                Console.WriteLine("Inpute the correct format");
            }


                Console.ReadKey();
        }
    }
}
