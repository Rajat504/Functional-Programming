using System;
using System.Collections.Generic;
using System.Text;

namespace Functional
{
    public class ReplaceString
    {
        public void Stringreplacement()
        {
            string result = "Hello <<UserName>>, How are you?";
            Console.WriteLine("enter name to be replaced");
            string replaceName = Console.ReadLine();
            char[] array = new char[10];
            array= replaceName.ToCharArray();
            if (array.Length >= 3)
                Console.WriteLine(result.Replace("<<UserName>>", replaceName));
            else
                Console.WriteLine("username should contain atleast 3 letters");
            }
    }
}
