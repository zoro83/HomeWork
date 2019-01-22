using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection.Sort
{
    // https://www.tutorialspoint.com/data_structures_algorithms/selection_sort_algorithm.htm
    // https://www.cs.usfca.edu/~galles/visualization/ComparisonSort.html
    class Program
    {
        public static void Swap(int[] arr, int index1, int index2)
        {
            if (arr[index1] != arr[index2])
            {
                int temp = arr[index2];
                arr[index2] = arr[index1];
                arr[index1] = temp;
            }
        }
        public static void SelectionSort(int[] arr)
        {
            int minIndex = 0;
            int min;
            bool flag = false;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                min = arr[i];
                flag = false;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    //temp = arr[i];
                    if (min > arr[j])
                    {
                        min = arr[j];
                        minIndex = j;
                        flag = true;
                    }
                }
                if (flag)
                    Swap(arr, i, minIndex);
            }
        }
        static void Main(string[] args)
        {
            int[] arr = new int[]
                {3,7,4,4,6,5,8,0,0,-4,88,2,1,-3,7};
            SelectionSort(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.ReadKey();
        }
    }
}
