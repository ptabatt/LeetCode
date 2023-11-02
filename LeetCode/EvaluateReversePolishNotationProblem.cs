using System;
using System.Collections.Generic;

namespace LeetCode
{
    // https://leetcode.com/problems/evaluate-reverse-polish-notation/?envType=study-plan-v2&envId=top-interview-150
    public class EvaluateReversePolishNotationProblem
    {
        public int EvalRPN(string[] tokens)
        {
            var numStack = new Stack<int>();

            foreach (var s in tokens)
            {
                if (s == "+" || s == "-" || s == "/" || s == "*")
                {
                    numStack.Push(Eval(s, numStack.Pop(), numStack.Pop()));
                }
                else
                {
                    numStack.Push(Convert.ToInt32(s));
                }
            }

            return numStack.Pop(); 
        }

        int Eval(string e, int a, int b)
        {
            switch (e)
            {
                case "+":
                    return b + a;
                case "-":
                    return b - a;
                case "*":
                    return b * a;
                case "/":
                default:
                    return b / a;

            }
        }
    }
}
