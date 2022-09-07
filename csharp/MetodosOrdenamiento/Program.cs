using System;
using System.Collections.Generic;
using System.Linq;

namespace MetodosOrdenamiento
{
    class Program
    {
        public static List<int> unsortedArray = new List<int>() { 5, 8, 9, 4, 3, 2, 1, 10, 6, 7 };
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("QuickSort");
                Console.WriteLine(string.Join(",", QuickSort(unsortedArray)));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static List<int> QuickSort(List<int> unsortedArray)
        {
            List<int> sortArray = new List<int>();

            if (unsortedArray.Count < 1)
            {
                return sortArray;
            }

            List<int> left = new List<int>();
            List<int> right = new List<int>();
            int pivot = unsortedArray[0];

            for (int i = 1; i < unsortedArray.Count; i++)
            {
                if (unsortedArray[i] < pivot)
                {
                    left.Add(unsortedArray[i]);
                }
                else
                {
                    right.Add(unsortedArray[i]);
                }
            }

            return sortArray.Concat(QuickSort(left)).Concat(new List<int>() { pivot }).Concat(QuickSort(right)).ToList();
        }
    }
}
