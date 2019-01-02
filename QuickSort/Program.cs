using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 3, 1, 2, 4, 11, 9, 5, 17, 34, 19, 16 };
            // Initially we will pass 0 as start and arr.Length as end.

            arr = QuickSort(arr,0,arr.Length-1);
            Console.Write("Sorted Array - ");
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.ReadKey();
        }

        public static int[] QuickSort(int[] arr,int start,int end)
        {
            if (start < end)
            {
                int pivotPosition = Partion(arr, start, end);
                // Now calling quick sort on two partioned array
                QuickSort(arr, start, pivotPosition - 1);
                QuickSort(arr, pivotPosition+1, end);
            }
            return arr;
            
        }

        private static int Partion(int[] arr, int start, int end)
        {
            // suppose last element is the pivot element
            int pivot = arr[end];
            // Lets assume the actual position of pivot element is staring index
            int pIndex = start;
            for(int i = start; i < end; i++)
            {
                if (arr[i] <= pivot)
                {
                    // swap both the element and update pivot position
                    int temp = arr[i];
                    arr[i] = arr[pIndex];
                    arr[pIndex] = temp;
                    pIndex++;
                }
            }
            int tem = arr[pIndex];
            arr[pIndex] = arr[end];
            arr[end] = tem;
            return pIndex; 
        }
    }
}