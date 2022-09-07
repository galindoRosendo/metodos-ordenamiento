using System;
using System.Collections.Generic;
using System.Linq;

namespace MetodosOrdenamiento
{
    class Program
    {
        #region Variables
        public static List<int> unsortedArray = new List<int>() { 5, 8, 9, 4, 3, 2, 1, 10, 6, 7 };
        #endregion
        static void Main(string[] args)
        {
            try
            {
                int methodId = 0;
                Console.WriteLine($"Select a sort method:\n1. Quick Sort \n2. Radix\n");
                methodId = Convert.ToInt32(Console.ReadLine());
                switch (methodId)
                {
                    case 1:
                        Console.WriteLine("Quick Sort Selected");
                        Console.WriteLine(string.Join(",", QuickSort(unsortedArray)));
                        break;
                    case 2:
                        Console.WriteLine("Radix Selected");
                        Console.WriteLine(string.Join(",", RadixSort(unsortedArray, unsortedArray.Count)));
                        break;
                    default:
                        Console.WriteLine("Invalida Method");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #region Public Methods
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
        public static List<int> RadixSort(List<int> unsortedArray, int size)
        {
            List<int> sortArray = new List<int>();

            var maxVal = GetMaxVal(unsortedArray, size);
            for (int exponent = 1; maxVal / exponent > 0; exponent *= 10)
                sortArray = CountingSort(unsortedArray, size, exponent);
            
            return sortArray;
        }
        #endregion
        #region Private Methods
        private static int GetMaxVal(List<int> list, int size)
        {
            var maxVal = list[0];
            for (int i = 1; i < size; i++)
                if (list[i] > maxVal)
                    maxVal = list[i];
            return maxVal;
        }
        private static List<int> CountingSort(List<int> array, int size, int exponent)
        {
            var outputArr = new int[size];
            var occurences = new int[10];
            for (int i = 0; i < 10; i++)
                occurences[i] = 0;
            for (int i = 0; i < size; i++)
                occurences[(array[i] / exponent) % 10]++;
            for (int i = 1; i < 10; i++)
                occurences[i] += occurences[i - 1];
            for (int i = size - 1; i >= 0; i--)
            {
                outputArr[occurences[(array[i] / exponent) % 10] - 1] = array[i];
                occurences[(array[i] / exponent) % 10]--;
            }
            for (int i = 0; i < size; i++)
                array[i] = outputArr[i];

            return array;
        }
        #endregion
    }
}
