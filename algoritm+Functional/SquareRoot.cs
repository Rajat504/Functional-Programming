using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
   public class SquareRoot
    {
        public static void NewtonsSquareRoot()
        {
            Console.WriteLine("enter the value");
            double c = Convert.ToDouble(Console.ReadLine());
            double epsilon = 1e-15;//given the formula
            double t = c;//(taken t=c as mentioned in question)
            //apply Newton step until desired accuracy is achieved
            while (Math.Abs(t - c / t) > epsilon * t)//appling the formula
            {
                t = (c / t + t) / 2.0;//replacing t with c/t and t

                Console.WriteLine(t);
            }
            Console.ReadLine();

        }
    }
}
