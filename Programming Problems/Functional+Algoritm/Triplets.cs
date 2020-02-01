 using System;
using System.Collections.Generic;
using System.Text;

namespace Functional
{
    public class Triplets
    {
        public void Tripletclass()
        {
            int[] arr = { 3, -1, -7, -4, -5, 9, 10 };
            for (int i = 0; i < arr.Length - 2; i++)
            {
                Console.WriteLine("enter the value of i");
                for (int j = i + 1; j < arr.Length - 1; j++)
                {
                    Console.WriteLine("enter the value of j");

                    for (int k = j + 1; k < arr.Length; k++)
                    {
                        Console.WriteLine("enter the value of k");
                        if (arr[i] + arr[k] + arr[j] == 0)
                        {
                            Console.WriteLine(arr[i]+" "+ arr[j] + " " + arr[k]);
                        }
                    }
                }
            }
        }
    }
}

            
