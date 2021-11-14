using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class RomanToIntegerProblem
    {
        public int RomanToInt(string s)
        {
            int iRunningTotal = 0;

            for (int i = 0; i < s.Length; i++)
            {
                switch (s[i])
                {
                    case 'I':
                        if (i == s.Length - 1)
                            iRunningTotal += 1;
                        else if (s[i + 1] == 'V' || s[i + 1] == 'X')
                            iRunningTotal -= 1;
                        else
                            iRunningTotal += 1;
                        break;
                    case 'V':
                        iRunningTotal += 5;
                        break;
                    case 'X':
                        if (i == s.Length - 1)
                            iRunningTotal += 10;
                        else if (s[i + 1] == 'L' || s[i + 1] == 'C')
                            iRunningTotal -= 10;
                        else
                            iRunningTotal += 10;
                        break;
                    case 'L':
                        iRunningTotal += 50;
                        break;
                    case 'C':
                        if (i == s.Length - 1)
                            iRunningTotal += 100;
                        else if (s[i + 1] == 'D' || s[i + 1] == 'M')
                            iRunningTotal -= 100;
                        else
                            iRunningTotal += 100;
                        break;
                    case 'D':
                        iRunningTotal += 500;
                        break;
                    case 'M':
                        iRunningTotal += 1000;
                        break;
                }
                    
            }
            
            return iRunningTotal;
        }
    }
}
