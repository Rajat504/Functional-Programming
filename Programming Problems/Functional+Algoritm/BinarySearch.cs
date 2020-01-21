using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
     public class BinarySearch
    {
        public static void BinaryS()
        {
            String[] arr = { "Rajat", "Adil", "Deep", "Shikhar", "Faraz", "Sarim", "Shanawar" };
            Console.WriteLine("enter the word to be found");
            String X = Console.ReadLine();
            int First = 0;
            int Last = arr.Length - 1;
            while (First <= Last)
            {
                int Middle = First + (Last - 1) / 2;
                int result = X.CompareTo(arr[Middle]);
                if (result == 0)
                    return;
                if (result > 0)
                    First = Middle + 1;
                else
                    Last = Middle - 1;
                if (result == -1)
                    Console.WriteLine("word not found");
                else
                    Console.WriteLine("word is found");

            }
            return;

        }
    }
}
