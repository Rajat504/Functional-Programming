using System;
using System.Collections.Generic;
using System.Text;

namespace Functional
{
    public class CouponNumbers
    {
        public void CN()
        {
            Console.WriteLine("enter the value of n");
            int n = Convert.ToInt32(Console.ReadLine());
            bool[] collection = new bool[n];
            int count = 0;
            int distinct = 0;
            Random random = new Random();
            while (distinct < n)
            {
                int i = Convert.ToInt32((random.Next(n)));
                count++;
                if (!collection[i])
                {
                    distinct++;
                    Console.WriteLine("total distinct numbers are" + distinct);
                    collection[i] = true;
                }
            }
            Console.WriteLine("total random numbers needed to make distinct" + count);
        }
              
    }

}





