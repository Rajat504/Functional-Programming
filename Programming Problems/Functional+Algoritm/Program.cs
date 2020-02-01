using System;

namespace DATA_STRUCTURE
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("1.Calendar,2.Arithmetic");
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:
                    Calendar CLNDR = new Calendar();                 
                    break;
                case 2:
                    Arithmetic AE = new Arithmetic(); 
                    break;
                default:
                    break;
            }
        }
    }
}
