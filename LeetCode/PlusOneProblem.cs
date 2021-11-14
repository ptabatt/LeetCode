using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class PlusOneProblem
    {
        public int[] PlusOne(int[] digits)
        {
            var lstDigits = new List<int>();

            bool bCarryOver = false;
            int i = digits.Length - 1;

            while(i >= 0 || bCarryOver)
            {
                if(i == -1)
                {
                    bCarryOver = false;
                    lstDigits.Add(1);
                }
                else if ((i == digits.Length - 1) || bCarryOver)
                {
                    var sum = digits[i] + 1;
                    if (sum > 9)
                    {
                        bCarryOver = true;
                        lstDigits.Add(0);
                    }
                    else
                    {
                        bCarryOver = false;
                        lstDigits.Add(sum);
                    }
                }
                else
                {
                    bCarryOver = false;
                    lstDigits.Add(digits[i]);
                }

                i--;
            }

            lstDigits.Reverse();
            return lstDigits.ToArray();
        }
    }
}
