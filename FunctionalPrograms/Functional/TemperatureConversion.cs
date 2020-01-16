using System;
using System.Collections.Generic;
using System.Text;

namespace Functional
{
    class TemperatureConversion
    {
        public static void Temperature()
        {
            double Faren,Celcius;
            Console.WriteLine("enter the temp. in farenheit");
            Celcius = double.Parse(Console.ReadLine());
            Console.WriteLine("enter the temp. in celcius");
            Faren = double.Parse(Console.ReadLine());
            double Farenheit= (5 / 9) * (Faren - 32);
            Console.WriteLine("enter the value of a");
            double celcius= 32 + (Celcius * 9/5);
            Console.WriteLine("enter the value of b");


        }
    }
}
