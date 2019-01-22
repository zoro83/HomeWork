using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Marge.Sort
{
    class Program
    {
        public static List<int> MergeSort(List<int> unsorted)
        {
            if (unsorted.Count <= 1)
            {
                return unsorted;
            }
            int leftSide = unsorted.Count / 2;
            int rightSide = unsorted.Count - leftSide;
            List<int> left = new List<int>(leftSide);
            List<int> right = new List<int>(rightSide);
            for (int i = 0; i < leftSide; i++)
            {
                left.Add(unsorted[i]);
            }
            for (int i = leftSide; i < unsorted.Count; i++)
            {
                right.Add(unsorted[i]);
            }
            left = MergeSort(left);
            right = MergeSort(right);
            
            return Merge(left, right);
        }
        public static List<int> Merge(List<int> left, List<int> right)
        {
            List<int> result = new List<int>();
            while (left.Count + right.Count > 0)
            {
                if (left.Count > 0 && right.Count > 0)
                {
                    if (left.First() <= right.First())
                    {
                        result.Add(left.First());
                        left.Remove(left.First());
                    }
                    else
                    {
                        result.Add(right.First());
                        right.Remove(right.First());
                    }
                }
                else if (left.Count > 0)
                {
                    result.Add(left.First());
                    left.Remove(left.First());
                }
                else if (right.Count > 0)
                {
                    result.Add(right.First());
                    right.Remove(right.First());
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            List<int> unsorted = new List<int>
            {7,8,2,5,1,0,3,11};
           List<int> sorted = MergeSort(unsorted);
            foreach (var item in sorted)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
