using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodWithArrayParameter
{
    class Program
    {
        static void IncressingOrDecressingArray(int[] arr, bool flag)
        {
            int[] newArr = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                if (flag)
                {
                    int maxIndex = arr.ToList().IndexOf(arr.Max());
                    newArr[i] = arr.Max();
                    arr[maxIndex] = int.MinValue;
                    Console.WriteLine(newArr[i]);
                }
                else
                {
                    int minIndex = arr.ToList().IndexOf(arr.Min());
                    newArr[i] = arr.Min();
                    arr[minIndex] = int.MaxValue;
                    Console.WriteLine(newArr[i]);
                }
            }
         
        }
        static void Main(string[] args)
        {
            int[] arr = { 8, 3, 44, 77, -44, 1,-129};

            Console.WriteLine("True");
            IncressingOrDecressingArray(arr, true);

            Console.WriteLine("False");
            IncressingOrDecressingArray(arr, false);
            Console.ReadKey();
        }
    }
}
