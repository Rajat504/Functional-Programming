using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DATA_STRUCTURE
{
    public class Banking
    {
        public static BS()
        {

            Queue tokennumber = new Queue();
            Queue accountnumber = new Queue();
            Queue Customername = new Queue();
            int tokennumber1 = 0;

            Console.WriteLine("adding a new customer");
            Console.WriteLine("enter your account number ");
            Console.WriteLine("enter the token no.");
            int Tokennumber = Convert.ToInt32(Console.ReadLine());
            int ch = int.Parse(Console.ReadLine());
            switch (ch)
            {
                Case 1:
                    Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("enter your account number");
            int AccountNumber = Convert.ToInt32(Console.ReadLine());
            tokennumber.Enqueue(tokennumber);
            Customername.Enqueue(Customername);
            accountnumber.Enqueue(accountnumber);
            Console.WriteLine(tokennumber1++);
            goto();

            Case 2:
            Console.WriteLine("\n select your transaction");
            Console.WriteLine("1.Deposit Money");
            Console.WriteLine("2.Widraw Money");
            Console.WriteLine("Print Passbook");
            Console.WriteLine("enter your selection");
            int M = Convert.ToInt32(Console.ReadLine());
        
            switch("DMoney")
            {
                case 1://deposit money
                    Console.WriteLine("enter your token number");
                    Console.WriteLine("enter the amount to be deposited");
                    int Money = Console.WriteLine();
                    Console.WriteLine("Cash Deposit");
                    Console.Write("\n 0.Please enter the account number");
                    Console.Write("\n 1.enter thye customer name");
                    Console.WriteLine("\n money accountnodeque,CustomerName Deque()");
                    Console.WriteLine("please enter your selection");
                    goto();
              case 2://withdraw money
              Console.WriteLine("\nYour Token No. {0} Please Attend at Counter :(B)\n", tokenno.Dequeue());
                               Console.Write("Enter the Amount to be Withdraw: ");
                               money = Utility.UserMoney();
                               Console.WriteLine("\n------------- Cash Withdraw Reciept -----------");
                               Console.WriteLine("\n\tCash Withdraw :   {0}\n\tAccount No :   {1}\n\tCust Name :    {2}\n", money, accno.Dequeue(), custName.Dequeue());

            }

                    

        }
            
    }
        
}
}
