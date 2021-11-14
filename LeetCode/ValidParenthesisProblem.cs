using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class ValidParenthesisProblem
    {
        /// <summary>
        /// Given a string s containing just the characters 
        /// '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
        /// An input string is valid if:
        /// Open brackets must be closed by the same type of brackets.
        /// Open brackets must be closed in the correct order.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public bool IsValid(string s)
        {
            var stack = new Stack<char>();

            foreach (var c in s)
            {
                switch (c)
                {
                    case '(':
                        stack.Push(c);
                        break;
                    case ')':
                        if (stack.Count > 0 && stack.Peek() == '(')
                            stack.Pop();
                        else
                            return false;
                        break;
                    case '[':
                        stack.Push(c);
                        break;
                    case ']':
                        if (stack.Count > 0 && stack.Peek() == '[')
                            stack.Pop();
                        else
                            return false;
                        break;
                    case '{':
                        stack.Push(c);
                        break;
                    case '}':
                        if (stack.Count > 0 && stack.Peek() == '{')
                            stack.Pop();
                        else
                            return false;
                        break;
                    default:
                        return false;
                }
            }

            return !(stack.Count > 0);
        }
    }
}
