using System.Collections.Generic;

namespace LeetCode
{
    public class LengthOfLongestSubstringProblem
    {
        /// <summary>
        /// Given a string s, find the length of the longest substring without repeating characters.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int LengthOfLongestSubstring(string s)
        {
            var colLongestSubStr = string.Empty;
            var strLongestPossible = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~ ";

            for (int i = 0; i <= s.Length - 1; i++)
            {
                for (int j = s.Length - i; j > colLongestSubStr.Length; j--)
                {
                    var subStr = s.Substring(i, j);

                    if(subStr.Length <= colLongestSubStr.Length)
                    {
                        break;
                    }
                    else if (!HasRepeatingChars(subStr))
                    {
                        colLongestSubStr = subStr;

                        if (colLongestSubStr.Length >= strLongestPossible.Length)
                            return colLongestSubStr.Length;
                    }
                }
            }

            return colLongestSubStr.Length;
        }

        private bool HasRepeatingChars(string s)
        {
            var dctChars = new Dictionary<char, int>();

            foreach (var c in s)
            {
                if (dctChars.ContainsKey(c))
                {
                    return true;
                }
                else
                {
                    dctChars[c] = 1;
                }
            }
            
            return false;
        }
    }
}
