using System;
using System.Collections.Generic;
using System.Text;

namespace Functional
{
    class Anagram
    {
        public void Anagramprogram()
        {
            bool status = true;
            //function to check wheteher the two programs are anagram or not
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();
            int n1 = str1.Length;
            int n2 = str2.Length;
            //if both the strings are not same they are not anagram
            if (n1 != n2)
            {
                status = false;
            }
            else
            {
                status = true;
            }
            //sorting both the strings
            for (int i = 0; i < str1.Length; i++)
            {
                if (str1 != str2)
                {
                    status = false;
                }
                else
                {
                    status = true;
                }
            }
        }
    }

}

