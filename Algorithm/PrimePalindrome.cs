using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
     public class PrimePalindrome
    {
        public static void PN(string[] args)
        {
            int num, temp, revnum = 0, rem;
            Console.WriteLine("enter a number");
            num = Convert.ToInt32(Console.ReadLine());
            temp = num;//121
            while (num > 0)
            {
                rem = num % 10;//1
                revnum = revnum * 10 + rem;//0*10+1=1
                num = num / 10;//12
                if (revnum == temp)
                {
                    Console.WriteLine("number is palindrome");
                }
                else
                    Console.WriteLine("number is not palindrome");
                Console.ReadLine();
            }


        }
    }
}
