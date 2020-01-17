using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms
{
    
    public  class WindChill
    {
        public void CalculateWindChill()
        {
            double t, v;
            Console.WriteLine("Enter the value of temperature t (in Fahrenheit) less than 50");
            t =double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value of wind speed v (in miles per hour) between 120");
            v = double.Parse(Console.ReadLine());
            //w = 35.74 + 0.6215 t + (0.4275 t - 35.75) v^0.16
            //t cannot be larger than 50
            //v is larger than 120
            double windChill = 35.74 + 0.6215 * t + (0.4275 * t - 35.75) * Math.Pow(v, 0.16);
            Console.WriteLine("windChill is: " + windChill);
        }
    }
}

