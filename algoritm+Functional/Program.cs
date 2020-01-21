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
                case 3:
                    Permutation.permute();
                    break;
                    case 4:
                    MergeSort.MergeSt();
                    break;
                case 5:
                    PrimePalindrome.PN();
                    
                    break;





                default:
                    break;
            }
        }
    }
}

