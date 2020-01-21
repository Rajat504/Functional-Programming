using System;
using System.Collections.Generic;
using System.Text;

namespace Functional
{
   public class Quadratic
    {
        public void QuadraticEquation()
        {
            Console.WriteLine("enter the value of a");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("enter the value of b");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("enter the value of c");
            double c = double.Parse(Console.ReadLine());
            double delta = b * b - 4 * a * c;
            if (delta >= 0)
            {
                double root1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double root2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("the root 1 is:{0}", root1);
                Console.WriteLine("the root 2 is {0}", root2);
            }
          
        }                                                        
    }
}
