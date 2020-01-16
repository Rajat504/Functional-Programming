using System;
using System.Collections.Generic;
using System.Text;

namespace Functional
{
    public class HeadandTail
    {
        public void Toss()
        {

            Console.WriteLine("No.of times you want to toss a coin");
            int no = int.Parse(Console.ReadLine());
            int head = 0;
            int tail = 0;
            for (int i = 1; i <= no; i++)
            {
                Random rand = new Random();
                int j = rand.Next(0, 2);
                if (j == 0)
                {
                    head = 1;
                    Console.WriteLine(head);
                }
                else
                {
                    tail = 1;
                    Console.WriteLine(tail);
                }
                    double a = (head * 100) / no;
                    double b = (tail * 100) / no;
                    double percentageofhead = a;
                    double percentageoftail = b;
                Console.WriteLine("head%:(0)and tail%:(1),percentageofHead,percentageofTail");
                }




            }
        }
}
