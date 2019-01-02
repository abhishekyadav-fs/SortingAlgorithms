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
            int[] arr = new int[] { 3, 1, 2, 4 };
            arr = InsertionSort(arr);
            Console.Write("Sorted Array - ");
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.ReadKey();
        }

        public static int[] InsertionSort(int[] arr)
        {
            int len = arr.Length;
            for (int i = 1; i < len; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (arr[j] > arr[i])
                    {
                        int temp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
            return arr;
        }
    }
}