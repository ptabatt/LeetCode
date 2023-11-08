using System;

namespace LeetCode
{
    // https://leetcode.com/problems/is-subsequence/?envType=study-plan-v2&envId=top-interview-150
    public class IsSubsequenceProblem
    {
        public bool IsSubsequence(string s, string t)
        {
            if (string.IsNullOrEmpty(s))
            {
                return true;
            }

            if (string.IsNullOrEmpty(s) && string.IsNullOrEmpty(t))
            {
                // weird edge case provided by Leetcode. I would argue
                // that nothing can be a substring of an empty string
                return true;
            }

            var j = 0;

            for (var i = 0; i < t.Length; i++)
            {
                if (s[j] == t[i])
                {
                    j++;
                }

                if (j > s.Length - 1)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
