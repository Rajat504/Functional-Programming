using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class Permutation
    {
      public static void permute(String str, int l, int r)
      {
            //let l be equal to r
            //put the value of l in i
            //increment the value of i
            if (l == r)
                Console.WriteLine(str);
            else
            {
                for (int i = l; i <= r; i++)
                {
                    str = swap(str, l, i);//swap the values
                    permute(str, l + 1, r);
                    str = swap(str, l, i);//put the swap value in the string
                }
            }
      }

 
        public static String swap(String a,int i, int j)
        {
            //take ac char temp value
            //put the stored value of i and j
            char temp;
            char[] charArray = a.ToCharArray();
            temp = charArray[i];
            charArray[i] = charArray[j];//let char of i be equal to char of j
            charArray[j] = temp;//put the value of j in temp
            string s = new string(charArray);
            return s;
        }

         
        public static void permute()
        {
            String str = "ABC";
            int n = str.Length;
            permute(str, 0, n - 1);
        }
    }
}

