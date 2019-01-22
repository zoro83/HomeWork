using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortPrintRandomArray
{
    class Program
    {
        /// <summary>
        /// Print Array numbers
        /// </summary>
        /// <param name="arr"></param>
        static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]}, ");
            }
        }
        /// <summary>
        /// Generate array with randome int values
        /// </summary>
        /// <param name="lenght">Array Length</param>
        /// <param name="min">Random min</param>
        /// <param name="max">Random max</param>
        /// <returns></returns>
        static int[] RandomArray(int lenght = 10, int min = 0, int max = 100)
        {
            int[] returnArray = new int[lenght];
            Random rd = new Random();
            //rd.Next(min, max);
            for (int i = 0; i < lenght; i++)
            {
                returnArray[i] = rd.Next(min, max);
            }
            return returnArray;
        }
        /// <summary>
        /// Swap array given two index
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="index1"></param>
        /// <param name="index2"></param>
        static void Swap(int[] arr, int index1, int index2)
        {
            if (index1 != index2)
            {
                int temp = arr[index1];
                arr[index1] = arr[index2];
                arr[index2] = temp;
                //arr[index2] = arr[index2] - arr[index1];
                //arr[index1] = arr[index1] + arr[index2];
                //arr[index2] = arr[index1] - arr[index2];
                //Console.WriteLine($"{arr[index1]}, {arr[index2]}");

            }

        }
        /// <summary>
        /// if true increase array, else decrease array
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="flag"></param>
        /// <returns></returns>
        static int[] SortArray(int[] arr, bool flag)
        {
            int[] cloneArr = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                cloneArr[i] = arr[i];
            }
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 1; j < arr.Length - i; j++)
                {
                    if (cloneArr[j - 1] > cloneArr[j])
                    {
                        Swap(cloneArr, j - 1, j);
                        //PrintArray(cloneArr);
                    }

                }
            }
            if (!flag)
            {
                for (int i = 0; i < (int)cloneArr.Length / 2; i++)
                {
                    Swap(cloneArr, i, cloneArr.Length - 1 - i);
                }
            }
            return cloneArr;
        }


        static void Main(string[] args)
        {
            //PrintArray(RandomArray(10, 8, 33));
            int[] arry = { 8, 5, 66, 4, 1 };
            // Swap(arr, 0, 2);

            arry = SortArray(arry, true);
            PrintArray(arry);
            Console.WriteLine();
            arry = SortArray(arry, false);
            PrintArray(arry);
            Console.ReadKey();
        }
    }
}
