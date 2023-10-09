using System.Text.RegularExpressions;

namespace LeetCode
{
    public class IsPalindromeProblem
    {
        //A phrase is a palindrome if, after converting all uppercase letters into lowercase letters and 
        //removing all non-alphanumeric characters, it reads the same forward and backward.Alphanumeric 
        //characters include letters and numbers.

        //Given a string s, return true if it is a palindrome, or false otherwise.

        public bool IsPalindrome(string s)
        {
            var rgx = new Regex("[^a-zA-Z0-9]");
            s = rgx.Replace(s, "");
            s = s.ToLower();

            if (s.Length == 0)
            {
                return true;
            }

            int j = s.Length - 1;
            for (int i = 0; i < s.Length/2; i++)
            {
                if (s[i] == s[j])
                {
                    j--;
                    continue;
                }

                return false;
            }

            return true;
        }
    }
}
