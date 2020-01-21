using System;
using System.Collections.Generic;
using System.Text;

namespace Functional
{
    class HarmonicNumber
    {
        //print the nth harmonic number
            public  void Harmonic()
            {


                Console.WriteLine("enter the number up to which you can run the harmonic series");
            //print the nth harmonic number
            int no = int.Parse(Console.ReadLine());
                if (no<=0)
                {
                    Console.WriteLine("Invalid No");

                }
                else
                {

                    float x =0;
                    for (float i = 1; i <= no; i++)
                    {
                        x = x + (1 / i);

                    }
                    Console.Write(x);
                }
            }
        }
    }



