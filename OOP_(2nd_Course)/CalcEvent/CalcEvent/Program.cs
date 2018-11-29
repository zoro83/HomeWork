using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcEvent
{
    public delegate float CalcDelegate(float num1, float num2);
    class MyCalc
    {
        public event CalcDelegate CalcEvent = null;
        public float EventInvoker(float num1, float num2)
        {
            return CalcEvent.Invoke(num1, num2);
        }

    }
    class Program
    {

        public static float HandllerAdd(float num1, float num2)
        {
            return num1 + num2;
        }
        public static float HandllerMinus(float num1, float num2)
        {
            return num1 - num2;
        }
        public static float HandllerMultyple(float num1, float num2)
        {
            return num1 * num2;
        }
        public static float HandllerDivide(float num1, float num2)
        {
            return num1 / num2;
        }
        static void Main(string[] args)
        {
            MyCalc myCalc = new MyCalc();
            bool flag = false;
            float sum = 0;
            Console.WriteLine("***Input Number one and number two for operation***");
            float num1 = float.Parse(Console.ReadLine());
            char operation = char.Parse(Console.ReadLine());
            float num2 = float.Parse(Console.ReadLine());
            Console.WriteLine("=");
            while (!flag)
            {
                switch (operation)
                {
                    case '+':
                        myCalc.CalcEvent += HandllerAdd;
                        sum = myCalc.EventInvoker(num1, num2);
                        Console.WriteLine(sum);
                        break;
                    case '-':
                        myCalc.CalcEvent += HandllerMinus;
                        sum = myCalc.EventInvoker(num1, num2);
                        Console.WriteLine(sum);
                        break;
                    case '*':
                        myCalc.CalcEvent += HandllerMultyple;
                        sum = myCalc.EventInvoker(num1, num2);
                        Console.WriteLine(sum);
                        break;
                    case '/':
                        myCalc.CalcEvent += HandllerDivide;
                        sum = myCalc.EventInvoker(num1, num2);
                        Console.WriteLine(sum);
                        break;
                    case '%':
                        myCalc.CalcEvent += (n, m) => n * m / 100;
                        sum = myCalc.EventInvoker(num1, num2);
                        Console.WriteLine(sum);
                        break;
                    default:
                        Console.WriteLine("Wrong operation");
                        break;
                }

                Console.WriteLine(new string('-', 22));
                Console.WriteLine(sum);
                num1 = sum;
                operation = char.Parse(Console.ReadLine());
                num2 = float.Parse(Console.ReadLine());
                Console.WriteLine("=");
                //Console.ReadKey();
            }

        }
    }
}
