using System;
using System.Collections.Generic;
using System.Text;

namespace Functional
{
   public class MontlyPayment
   {
        
        
            public void MonthlyP()
            {
                Console.WriteLine("enter the value of p");
                double p = double.Parse(Console.ReadLine());
                Console.WriteLine("enter the value of y");
                double y = double.Parse(Console.ReadLine());
                Console.WriteLine("enter the value of r");
                double r = double.Parse(Console.ReadLine());
                double MontlyPayment = (p * r) / (1 - Math.Pow((1 + r), (1 - r)));
                Console.WriteLine("Montly payment is", MontlyPayment);
            }
        
   }
}


