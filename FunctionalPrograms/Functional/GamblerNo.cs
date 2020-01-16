using System;
using System.Collections.Generic;
using System.Text;

namespace Functional
{
   public class GamblerNo
    {
        public void Gambler()
        {

            Console.WriteLine("Place your stake(initial money)");
            int stake = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Place your goal(max.money)");
            int goal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("place your times");
            int times = Convert.ToInt32(Console.ReadLine());
            int Wins = 0;
            int Loss = 0;
            int Bets = 1;
            double win;
            double loss;
            Random rand = new Random();
            while (stake>0 &&stake<goal &&times>0)
            {
                //Bets = 1;
                
                int n = rand.Next(0, 2);
                //console.writeline(r);
                if (n == 0)
                {
                    stake += 1;
                    win = 1;
                }
                else
                {
                    stake -= 1;
                    loss = 1;
                    times -= 1;
                    
                }
                
                

                }


            }

          


    }
    }
