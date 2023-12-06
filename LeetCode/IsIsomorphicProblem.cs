using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class IsIsomorphicProblem
    {
        // https://leetcode.com/problems/isomorphic-strings/
        // Constraints:  

        // 1 <= s.length <= 5 * 104
        // t.length == s.length
        // s and t consist of any valid ascii character.
        public bool IsIsomorphic(string s, string t)
        {
            var dct = new Dictionary<char, char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (dct.TryGetValue(s[i], out char val))
                {
                    if (!(t[i] == val))
                    {
                        return false;
                    }
                }
                else
                {
                    if (dct.ContainsValue(t[i]))
                    {
                        return false;
                    }

                    dct[s[i]] = t[i];
                }
            }

            return true;
        }
    }
}
