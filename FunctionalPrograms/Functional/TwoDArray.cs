using System;
using System.Collections.Generic;
using System.Text;

namespace Functional
{
    class TwoDArray
    {
        public void TwoArray()
        {
            Console.WriteLine("creating two dd array");
            Console.WriteLine("enter the M coloumns");
            int coloumn=int.Parse(Console.ReadLine());
            Console.WriteLine("enter the no.of rows");
            int rows = int.Parse(Console.ReadLine());
            int[,] array = new int[rows, coloumn];
            Console.WriteLine("print your elements");
            for(int i=0;i<rows;i++)
            {
                for(int j = 0; i < rows; i++)
                {
                    array[i, j] = int.Parse(Console.ReadLine());

                }
            }
            for(int i = 0; i < rows; i++)
            {
                for (int j = 0; j < coloumn; j++) 
                {
                    Console.WriteLine(array[i, j] + "");

                }
            }
            Console.WriteLine();
        }
    }
}
