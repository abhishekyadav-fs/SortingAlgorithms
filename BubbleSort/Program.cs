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
            int[] arr = new int[] { 4,9,6,3,1,11,2};
            arr = SelectionSort(arr);
            Console.Write("Sorted Array - ");
            foreach(var item in arr)
            {
                Console.Write(item+" ");
            }
            Console.ReadKey();
        }

        public static int[] SelectionSort(int[] arr)
        {
            int len = arr.Length;
            for(int i = 0; i < len - 1; i++)
            {
                int imin = i;
                for(int j = i + 1; j < len; j++)
                {
                    if (arr[j] < arr[imin])
                    {
                        imin = j;
                    }
                }
                int temp = arr[i];
                arr[i] = arr[imin];
                arr[imin] = temp;
            }
            return arr;
        }
    }
}
