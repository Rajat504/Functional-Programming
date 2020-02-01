using System;
using System.Collections.Generic;
using System.Text;

namespace Functional
{
    public class LeapYear
    {
        public void Year()
        {
            Console.WriteLine("enter the year");
            int Year = int.Parse(Console.ReadLine());
            if (Year >= 1500 && Year <= 9999)
            {
                if ((Year % 4 == 0) || (Year % 400 == 0) && (Year % 100 != 0))
                {
                    Console.WriteLine("its a leap year");
                }
                else
                {
                    Console.WriteLine("its not a leap year");
                }
            }

            else
            {
                Console.WriteLine("invalid year");
               
            }
        }
    }
}
