using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustSortings
{
    class QuickSort
    {
        private int partition(int[] array, int start, int end)
        {
            int temp;
            int marker = start;
            for (int i = start; i < end; i++)
            {
                if (array[i] < array[end]) 
                {
                    temp = array[marker];
                    array[marker] = array[i];
                    array[i] = temp;
                    marker += 1;
                }
            }
            
            temp = array[marker];
            array[marker] = array[end];
            array[end] = temp;
            return marker;
        }

        public void Sort(ref int[] array, int start, int end)
        {
            if (start >= end)
            {
                return;
            }
            int pivot = partition(array, start, end);
            Sort(ref array, start, pivot - 1);
            Sort(ref array, pivot + 1, end);
        }
    }
}
