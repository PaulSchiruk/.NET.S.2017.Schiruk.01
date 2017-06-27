using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SortAlgorithm;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[20] { 9, 63, -77, 19, 40, 42, 1, -73, -27, -92, 60, 22, 71, -3, 55, 76, 51, 24, 61, 3 };
            int[] array2 = new int[20] { 9, 63, -77, 19, 40, 42, 1, -73, -27, -92, 60, 22, 71, -3, 55, 76, 51, 24, 61, 3 };
            int[] array3 = new int[20] { 9, 9, int.MaxValue, 19, -40, 9, 0, -73, -27, -92, 60, int.MinValue, 71, -3, 55, 76, -0, 24, 61, 3 };
            int[] array4 = new int[20] { 9, 9, int.MaxValue, 19, -40, 9, 0, -73, -27, -92, 60, int.MinValue, 71, -3, 55, 76, -0, 24, 61, 3 };


            Console.Write("Array 1: ");
            ShowArray(array1);
            Console.Write("\nArray 2: ");
            ShowArray(array3);

            SortAlgorithm.QuickSort.Sort(array1, OtherComparer);
            Console.Write("\n\nSorted array1 with nonedefault comparer: ");
            ShowArray(array1);
            SortAlgorithm.QuickSort.Sort(array1);
            Console.Write("\nSorted array1 with default comparer: ");
            ShowArray(array1);
            SortAlgorithm.QuickSort.Sort(array3);
            Console.Write("\nSorted array2: ");
            ShowArray(array3);

            Console.ReadLine();
        }

        private static void ShowArray(int[] arr)
        {
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
        }

        private static int OtherComparer(int a, int b) => b - a;


    }
}
