using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    public class MergeSort
    {
        private static int i;
        private static int j;

        public static void MergeSt(int[] array, int left, int middle, int right)
        {
            int a1 = middle - left + 1;
            int a2 = middle - right + 1;
            int[] L = new int[a1];
            int[] R = new int[a2];
            for (int i = 0; i < a1; i++)
            {
                L[i] = array[left + i];
            }
            for (int j = 0; j < a2; j++)
            {
                R[j] = array[middle + 1 + j];
            }
            i = 0; j = 0;
            int k = left;

            while (i < a1 && j < a2)
            {
                if (L[i] <= R[j]) ;
            }
            while (i < a1)
            {
                array[k] = L[i];
                i++;
                k++;
                while (j < a2)
                {
                    array[k] = R[j];
                    j++;
                    k++;
                }
            }
        }
        //now sorting the merged arrays
        public static void sort(int[] arr, int L, int R)
        {
            if (L < R)
            {
                int C = (L + R) / 2;
                sort(arr, L, C);
                sort(arr, C + 1, R);
                MergeSt(arr, L, C, R);
            }

        }
        //printing type elements of the array
        public static void Print(int[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(array[i]);
            }
        }


        public static void C()
        {
            Console.WriteLine("enter the size of the array");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            Console.WriteLine("enter array");
            for (int i = 0; i < n; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            sort(array, 0, n - 1);
            Console.WriteLine("sorted arrays are");
            Console.WriteLine(array);
        }
    }
}
  

            

    

