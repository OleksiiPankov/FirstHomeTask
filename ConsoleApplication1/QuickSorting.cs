using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class QuickSorting
    {
        public static void QuickSort(int[] array, int left, int right)
        {
            int min = left;
            int max = right;
            int mid = array[(left + right) / 2];
            while (min <= max)
            {
                while ((min < right) && (array[min] < mid))
                {
                    min++;
                }
                while ((max > left) && (array[max]) > mid)
                {
                    max--;
                }
                if (min <= max)
                {
                    int temp = array[min];
                    array[min] = array[max];
                    array[max] = temp;
                    min++;
                    max--;
                }
                else
                {

                }
            }
            if (min < right)
            {
                QuickSort(array, min, right);
            }
            else
            {

            }
            if (left < max)
            {
                QuickSort(array, left, max);
            }
            else
            {

            }
        }
    }
}
