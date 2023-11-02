using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    // https://leetcode.com/problems/valid-anagram/?envType=study-plan-v2&envId=top-interview-150
    public class IsAnagramProblem
    {
        // Note: a true anagram doesn't care about case sensitivity, but the problem
        // explicitly states s and t will be all lowercase.
        public bool IsAnagram(string s, string t)
        {
            var dctS = new Dictionary<char, int>();
            var dctT = new Dictionary<char, int>();

            foreach (var c in s)
            {
                if (char.IsWhiteSpace(c))
                {
                    continue;
                }

                if (dctS.TryGetValue(c, out int count))
                {
                    dctS[c] = ++count;
                }
                else
                {
                    dctS[c] = 1;
                }
            }

            foreach (var c in t)
            {
                if (dctT.TryGetValue(c, out int count))
                {
                    dctT[c] = ++count;
                }
                else
                {
                    dctT[c] = 1;
                }
            }

            if (dctS.Count != dctT.Count)
            {
                return false;
            }

            foreach (var entry in dctS)
            {
                if (dctT.TryGetValue(entry.Key, out int count))
                {
                    if (entry.Value != count)
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }

            return true;
        }
    }
}
