using System.Collections.Generic;

namespace LeetCode
{
    public class WordPatternProblem
    {
        // https://leetcode.com/problems/word-pattern/?envType=study-plan-v2&envId=top-interview-150
        public bool WordPattern(string pattern, string s)
        {
            var dct = new Dictionary<char, string>();
            var arr = s.Split(' ');

            if (pattern.Length != arr.Length)
            {
                return false;
            }

            for (int i = 0; i < pattern.Length; i++)
            {
                if (dct.ContainsKey(pattern[i]))
                {
                    if (!string.Equals(dct[pattern[i]], arr[i]))
                    {
                        return false;
                    }
                } 
                else if (dct.ContainsValue(arr[i]))
                {
                    return false;
                }
                else
                {
                    dct[pattern[i]] = arr[i];
                }
            }

            return true;
        }
    }
}
