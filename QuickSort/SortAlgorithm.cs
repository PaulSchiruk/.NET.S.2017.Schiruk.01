using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithm
{
    public static class QuickSort
    { 
        public static void Sort(int[] array, Comparison<int> comparison = null) 
        {
            if (array == null) 
                throw new ArgumentNullException();
            if (comparison == null)
                comparison = CompareByIncrease;

            SortItself(array, 0, array.Length - 1, comparison);
        }
        private static void SortItself(int[] set, int left, int right, Comparison<int> comparer)
        {
            int i = left, j = right;
            int tmp;
            int mid = set[(left + right) / 2];

            while (i <= j)
            {
                while (comparer.Invoke(set[i], mid) < 0)
                    i++;
                while (comparer.Invoke(set[j], mid) > 0)
                    j--;
                if (i <= j)
                {
                    tmp = set[i];
                    set[i] = set[j];
                    set[j] = tmp;
                    i++;
                    j--;
                }

                if (left < j)
                    SortItself(set, left, j, comparer);
                if (i < right)
                    SortItself(set, i, right, comparer);
            }
        }
        private static int CompareByIncrease(int a, int b) => a - b;
    }
}




