using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionAndHeapSorting
{
    public class SelectionSort
    {
        int[] arr;

        public SelectionSort(int[] array)
        {
            arr = array;
        }

        private int FindMax(int legth)
        {
            int max = 0;
            int maxIndex = 0;
            for (int i = 0; i < legth; i++)
            {
                if(arr[i] > max)
                {
                    max = arr[i];
                    maxIndex = i;
                }
            }
            return maxIndex;
        }

        public int[] Sort()
        {
            for(int i = 0; i < arr.Length; i++)
            {
                int valueToSwap = FindMax(arr.Length - i);
                Swap(valueToSwap, arr.Length - 1 - i);
            }
            return arr;
        }

        private void Swap(int index1, int index2)
        {
            int value = arr[index2];
            arr[index2] = arr[index1];
            arr[index1] = value;
        }
    }
}
