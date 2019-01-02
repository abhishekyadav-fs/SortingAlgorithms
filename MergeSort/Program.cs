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
            int[] arr = new int[] { 3, 1, 2, 4, 11, 9, 5, 17, 34, 19, 16};
            arr = MergeSort(arr);
            Console.Write("Sorted Array - ");
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.ReadKey();
        }

        public static int[] MergeSort(int[] arr)
        {
            int len = arr.Length;
            // Base condition for recusion

            if (len < 2)
            {
                return arr;
            }
            int mid = len / 2;
            int[] left = new int[mid];
            int[] right = new int[len - mid];
            for(int i = 0; i < mid; i++)
            {
                left[i] = arr[i];
            }
            for (int i = mid; i < len; i++)
            {
                right[i-mid] = arr[i];
            }
            // Recursively calling MergeSort for left and rght array
            MergeSort(left);
            MergeSort(right);            
            return Merge(left, right, arr); ;
        }
        public static int[] Merge(int[] left,int[] right,int[] arr)
        {
            int i = 0,j = 0,k = 0;
            int ll = left.Length;
            int rl = right.Length;

            // Compare and copy elements from rigth and left array to main array
            //untill we reach end of left or rigth array 
            while(i<ll && j < rl)
            {
                if (left[i] < right[j])
                {
                    arr[k] = left[i];
                    i++;
                }
                else
                {
                    arr[k] = right[j];
                    j++;
                }
                k++;
            }

            // Once we came out of loop then copy remaining element to array
            while (i < ll)
            {
                arr[k] = left[i];
                i++;
                k++;
            }
            while (j < rl)
            {
                arr[k] = right[j];
                j++;
                k++;
            }
            return arr;
        }
         
    }
}