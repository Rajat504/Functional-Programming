using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    public class DayOfWeek
    {
        public static void DW()
        {
             
            Console.WriteLine("enter the D day");
            int Day = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the M month");
            int Month = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the Y year");
            int Year=int.Parse(Console.ReadLine());
            int y0 = Year - (14 - Month) / 12;
            int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
            int m0 = Month + 12 * ((14 - Month) / 12) - 2;
            int d0 = (Day + x + 31*m0 / 12) %  7;


        }
    }
}
