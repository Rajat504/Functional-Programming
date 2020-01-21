using Algorithm;
using System;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("1.Vending Machine,2.Day of week,3.Permutation");
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:
                    VendingMachine1.Calculate();   
                    break;
                case 2:
                    DayOfWeek.DW();     
                    break;




                default:
                    break;
            }
        }
    }
}

