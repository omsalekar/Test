using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailySparks
{
    public class Valid_Paranthisis
    {
       
            public bool IsValid(string s)
            {
                Stack<char> stack = new Stack<char>();

                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] == '(' || s[i] == '{' || s[i] == '[')
                    {
                        stack.Push(s[i]);
                    }
                    else
                    {
                        if (stack.Count > 0 && (
                        (stack.Peek() == '(' && s[i] == ')') ||
                        (stack.Peek() == '{' && s[i] == '}') ||
                        (stack.Peek() == '[' && s[i] == ']'))
                        )
                        {
                            stack.Pop();
                        }
                        else
                        {
                            return false;
                        }
                    }

                }
                return stack.Count == 0;
            }
        }
    }

