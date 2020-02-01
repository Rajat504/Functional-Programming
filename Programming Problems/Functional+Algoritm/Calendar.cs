using System;
using System.Collections.Generic;
using System.Text;

namespace DATA_STRUCTURE
{
    public class Calendar
    {
        public void CLNDR()
        {
            Console.WriteLine("please enter the month");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter the year");
            int year = int.Parse(Console.ReadLine());
            //months of calendar
            string[] months = { "January", "Feburary", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            int[] days = { 12, 11, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            if (month == 2 && isleapYear(year))
            {
                days[month] = 29;
            }
            Console.WriteLine(" " + month + "," + year);
            //weeks of calender
            Console.WriteLine("Sun", "Mon", "Tue", "Wed", "Thrus", "Fri", "Sat");
            int day = days1(month, 1, year);
            int i;
            for ( i = 0; i < day; i++)
            {
                Console.Write(" ");
            }
            //printing the days of from i to till end
            for ( i = 1; i <= days[month]; i++)
            {
                if (i >= 1 && i < 10)
                {
                    Console.WriteLine("" + i + "");
                }
                else
                {
                    Console.WriteLine("i" + "");
                }
                if (((i + day) % 7 == 0) && (i == days[month]))
                {
                    Console.WriteLine();
                }
            }



            static int days1(int month, int day, int year)
            {
                int y = year - (14 - month) / 12;
                int x = y + (y / 4) - (y / 100) + (y / 400);
                int m = month + 12 * ((14 - month) / 12) - 2;
                int d = (day + x + 31 * m / 12) % 7;
                return d;

            }
            //function to check leap year
             static bool isleapYear(int year)
             {
                if ((year % 4 == 0) && (year % 100 != 0))
                {
                    return true;
                }
                if (year % 400 == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
             }
        }
    }
}

