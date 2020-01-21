using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
   public class RegisteredClass
    {
        public static void RegisteredC(string[] args)
        {
            
            String s1 = ("hello <<name>>,we have your full name as <<full name>> in our system.your contact number is 91-xxxxxxxxxx");
            //now take name from the user
            Console.WriteLine("enter your full name");
            string fullName = Console.ReadLine();
            String[] strArr = new String[2];
            strArr = fullName.Split(" ");
            //replace the full name and name 
            String replacename = s1.Replace("<<name>>", strArr[0]);
            String replacefullname = replacename.Replace("<<fullname>>", fullName);
            //now take the mobile number from the user
            //now take the mobile number from the user
            Console.WriteLine("enter your mobile no");
            string Regex = "[0-9]{10}";
            string  MobileNo = Console.ReadLine();
            string replaceMobileNo =Regex.Replace("<<replace number>>", MobileNo);
            Console.WriteLine("enter number", MobileNo);
            Console.ReadLine();
            //now to take the date of birth from the user
            Console.WriteLine("enter your date of birth");                   
            string date  = Console.ReadLine();
            Console.WriteLine("enter a date");
            DateTime userDateTime;
            if (DateTime.TryParse(Console.ReadLine(), out userDateTime))
            {
                Console.WriteLine("The day of the week is: " + userDateTime.DayOfWeek);
            }
            else
            {
                Console.WriteLine("You have entered an incorrect datevalue.");
            }
            Console.ReadLine();


























        }
          
   }

}

