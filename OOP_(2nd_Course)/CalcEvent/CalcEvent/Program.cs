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

        #region Operations
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
        #endregion
       
        static void Main(string[] args)
        {
            MyCalc myCalc = new MyCalc();

            bool flag = false;

            float sum = 0;

            Console.WriteLine("***Input number one Than operation(+,-,*,/,%,^) nand finaly number two***");
            float num1 = float.Parse(Console.ReadLine());

            char operation = Convert.ToChar(Console.ReadLine());

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
                        myCalc.CalcEvent += (x, y) => x * y / 100; // Lambda Expression
                        sum = myCalc.EventInvoker(num1, num2);
                        Console.WriteLine(sum);
                        break;
                    case '^':
                        myCalc.CalcEvent += (x, y) => (float)Math.Pow(x, y); // Lambda Expression
                        sum = myCalc.EventInvoker(num1, num2);
                        Console.WriteLine(sum);
                        break;
                    case 'q':
                        flag = true;
                        break;
                        
                    default:
                        Console.WriteLine("Wrong operation");
                        break;
                }
                Console.WriteLine(new string('-', 22));
                Console.WriteLine(sum);
                num1 = sum;
                operation = Convert.ToChar(Console.ReadLine());
                num2 = float.Parse(Console.ReadLine());
                Console.WriteLine("=");
            }

        }
    }
}
