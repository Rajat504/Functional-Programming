using System;
using System.Collections.Generic;
using System.Text;

namespace Functional
{
   public class InsertionSort
    {
        public void insort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; i++)
            {
                int r = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > r)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = r;                
            }
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");

            Console.Write("\n");
        }
        public void Mainsorting()
        {
            int[] arr = { 12, 11, 13, 5, 6 };
            InsertionSort ob = new InsertionSort();
            ob.insort(arr);
        }
        
    }
}
