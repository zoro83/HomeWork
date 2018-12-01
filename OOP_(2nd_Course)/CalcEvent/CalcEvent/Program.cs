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
        public static float FloatPars(string str)
        {
            float res = 0;
            try
            {
                res = float.Parse(str);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Field Name:  {0}", e.TargetSite);
                Console.WriteLine("Class Name:  {0}", e.TargetSite.DeclaringType);
                Console.WriteLine("Field type:  {0}", e.TargetSite.MemberType);
                Console.WriteLine("Message:     {0}", e.Message);
                Console.WriteLine("Source:      {0}", e.Source);
                Console.WriteLine("DateTime:    {0}", DateTime.Now);
                Console.WriteLine("StackTrace:  {0}", e.StackTrace);
                Console.WriteLine("GetType:     {0}", e.GetType());
            }
            catch (Exception e)
            {
                Console.WriteLine("Field Name:  {0}", e.TargetSite);
                Console.WriteLine("Class Name:  {0}", e.TargetSite.DeclaringType);
                Console.WriteLine("Field type:  {0}", e.TargetSite.MemberType);
                Console.WriteLine("Message:     {0}", e.Message);
                Console.WriteLine("Source:      {0}", e.Source);
                Console.WriteLine("DateTime:    {0}", DateTime.Now);
                Console.WriteLine("StackTrace:  {0}", e.StackTrace);
                Console.WriteLine("GetType:     {0}", e.GetType());
            }
            return res;
        }
        public static char CharPars(string str)
        {
            char res = ' ';
            try
            {
                res = char.Parse(str);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Field Name:  {0}", e.TargetSite);
                Console.WriteLine("Class Name:  {0}", e.TargetSite.DeclaringType);
                Console.WriteLine("Field type:  {0}", e.TargetSite.MemberType);
                Console.WriteLine("Message:     {0}", e.Message);
                Console.WriteLine("Source:      {0}", e.Source);
                Console.WriteLine("DateTime:    {0}", DateTime.Now);
                Console.WriteLine("StackTrace:  {0}", e.StackTrace);
                Console.WriteLine("GetType:     {0}", e.GetType());
            }
            catch (Exception e)
            {
                Console.WriteLine("Field Name:  {0}", e.TargetSite);
                Console.WriteLine("Class Name:  {0}", e.TargetSite.DeclaringType);
                Console.WriteLine("Field type:  {0}", e.TargetSite.MemberType);
                Console.WriteLine("Message:     {0}", e.Message);
                Console.WriteLine("Source:      {0}", e.Source);
                Console.WriteLine("DateTime:    {0}", DateTime.Now);
                Console.WriteLine("StackTrace:  {0}", e.StackTrace);
                Console.WriteLine("GetType:     {0}", e.GetType());
            }
            return res;
        }

        static void Main(string[] args)
        {
            MyCalc myCalc = new MyCalc();

            bool flag = false;

            float sum = 0;

            Console.WriteLine("***Input number one Than operation(+,-,*,/,%,^,q=Exit) nand finaly number two***");
            float num1 = FloatPars(Console.ReadLine());     // try to convert to float

            char operation = CharPars(Console.ReadLine());  // try to convert to char

            float num2 = FloatPars(Console.ReadLine());     // try to convert to float

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
                if (!flag)
                {
                    Console.WriteLine(new string('-', 22));
                    Console.WriteLine(sum);
                    num1 = sum;
                    operation = CharPars(Console.ReadLine());   // try to convert to char
                    num2 = FloatPars(Console.ReadLine());       // try to convert to float
                    Console.WriteLine("=");
                }
            }

        }
    }
}
