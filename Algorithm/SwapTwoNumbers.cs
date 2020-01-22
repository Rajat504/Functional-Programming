using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
  public class SwapTwoNumbers
    {
        public void SWN()
        {
            Console.WriteLine("enter the decimal no.");
            //take two variables;
            // now converting the integer into binary form
            int num = Convert.ToInt32(Console.ReadLine());
            int power = 1;
            while (power <= num / 2)
            {
                power *= 2;
            }
            while (power>0)
            {
                if (num < power) 
                {
                    Console.WriteLine(0);
                }
                else
                {
                    Console.WriteLine(1);
                    num = power;
                }
                power /= 2;
            }
            Console.WriteLine("enter your choice:\n 1.swapp nibbles\n 2.Find the resultant number");
            int opp = Convert.ToInt32(Console.ReadLine());
            switch(opp)
            {
                case 1:
                    int number1 = Convert.ToInt32(Console.ReadLine());
                    int c = (number1 & 0x0F) << 4 | (number1 & 0xF0) >> 4;
                    Console.WriteLine(Math.Pow(c, 2));
                    break;
            }
            
           

            


        }
    }
}
