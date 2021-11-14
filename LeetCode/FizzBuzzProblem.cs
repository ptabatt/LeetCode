using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class FizzBuzzProblem
    {
        /// Given an integer n, return a string array answer (1-indexed) where:
        /// answer[i] == "FizzBuzz" if i is divisible by 3 and 5.
        /// answer[i] == "Fizz" if i is divisible by 3.
        /// answer[i] == "Buzz" if i is divisible by 5.
        /// answer[i] == i if non of the above conditions are true.
        public IList<string> FizzBuzz(int n)
        {
            var colResult = new List<string>();

            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    colResult.Add("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    colResult.Add("Fizz");
                }
                else if (i % 5 == 0)
                {
                    colResult.Add("Buzz");
                }
                else
                {
                    colResult.Add(i.ToString());
                }
            }

            return colResult;
        }
    }
}
