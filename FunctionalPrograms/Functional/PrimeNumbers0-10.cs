using System;
using System.Collections.Generic;
using System.Text;

namespace Functional
{
    public class PrimeNumbers0_10
    {
        public void Prime()
        {
            bool Primeflag = true;
            Console.WriteLine("Prime Numbers:0-100");
            for (int i = 0; i <= 100; i++)
               
            {
                for (int j = 2; j <= i/2; j++)
                {

                    if (i != j && i % j == 0)
                    {
                         Primeflag = false;
                        break;
                    }

                }
                if (Primeflag)
                {
                    Console.WriteLine("\t" + i);
                }
                Primeflag = true;
                
            }
            Console.ReadKey();


        }
    }
}
