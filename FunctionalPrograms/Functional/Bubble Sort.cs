using System;
using System.Collections.Generic;
using System.Text;

namespace Functional
{
    public class Bubble_Sort
    {
        public void SortingBubble(int[] arr, int n)
        {

            int temp;
            // Sorting strings using bubble sort 
            for (int i = 0; i < n-1; i++)
            {
                for (int j = i + 1; j< n; j++)
                {
                    if (arr[j].CompareTo(arr[i]) > 0)
                    {
                        temp = arr[j];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }

        public void Sortingnumber()
        {
            int[] arr = { 40,50,70,80,90,100 };
            int n = arr.Length;
            SortingBubble(arr, n);
            Console.WriteLine("integers in sorted order are : ");
            for (int j = 0; j < n; j++)
                Console.WriteLine("integers" + (j + 1) +
                                  " is " + arr[j]);
        }
    }
}

    

    

