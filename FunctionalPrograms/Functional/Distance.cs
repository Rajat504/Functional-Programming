using System;
using System.Collections.Generic;
using System.Text;

namespace Functional
{
     public class Distance
    {
        public void distancefunction()
        {
            Console.WriteLine("enter the value of x");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("enter the value of y");
            double y = double.Parse(Console.ReadLine());
            //applying the formula
            double Distance = Math.Sqrt(x * x + y * y);
            Console.WriteLine("distance is:{0}", Distance);
        }

    }
}
