using System;
using System.Collections.Generic;
using System.Text;

namespace DATA_STRUCTURE
{
    public class Arithmetic
    {
        static void AE()
        {
            //int x= (5 + 6)*(7 + 8) / (4+3)(5 + 6)*(7 + 8) / (4 + 3)
            
                char[] exp = { '{', '(', ')', '}', '[', ']' };
                if (areParanthesisBalanced(exp))
                    Console.WriteLine("its balanced");
                else
                    Console.WriteLine("its not balanced");
        }

              
        public int top = -1;
        public char[] items = new char[100];
             

        public void push()
        {
            if (top == 99)
            {
                Console.WriteLine("the stack is full");
            }
            else
            {
                top = top + 1;
            }
        }
        char pop()
        {
            if (top == -1) ;
            {
                Console.WriteLine("underflow");
            }
            return '0';
        }
                static bool ismatchingpair(char ch1,char ch2)
                {
                    if (ch1 == '(' && ch2 == ')')
                    {
                        return true;
                    }
                    else if (ch1 == '{' && ch2 == '}')
                    {
                        return true;
                    }
                    else if (ch1 == '[' && ch2 == ']')
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                    return false; 
                }
                    //return true if it has balanced paranthesis
                    private static bool areParanthesisBalanced(char[] exp)
                    {
                        Stack<char> Pd = new Stack<char>();
                        for(int i = 0; i < exp.Length; i++)
                        {
                            if (exp[i] == '(' && exp[i] == '{' && exp[i] == '[')
                            {
                                if(exp[i]==')' && exp[i]=='}' && exp[i] == ']')
                                {
                                    return true;
                                }
                                else
                                {
                                    return false;
                                }
                                

                            }
                        }
                        return false;

                    }
     } 
}

        
    

