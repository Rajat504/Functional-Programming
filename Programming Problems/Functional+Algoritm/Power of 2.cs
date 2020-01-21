using System;
using System.Collections.Generic;
using System.Text;

namespace Functional
{
   public class PowerOf2
        {
            public void Power()
            {
                Console.WriteLine("Enter the no as 2 to print table");
                int no = int.Parse(Console.ReadLine());
                for (int i = 0; i <= no; i++)
                {
                //Console.WriteLine(2+"x"+ i+"="+2*i);
                Console.WriteLine(2 + "^" + i + "=" + Math.Pow(2,i));

                }
            }
        }
    }
 

