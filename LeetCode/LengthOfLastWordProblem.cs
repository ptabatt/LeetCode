using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class LengthOfLastWordProblem
    {
        public int LengthOfLastWord(string s)
        {
            var iLength = 0;

            for (int i = s.Length-1; i > -1; i--)
            {
                if (s[i] == ' ' && iLength > 0)
                {
                    return iLength;
                }
                else if (s[i] == ' ')
                {
                    continue;
                }
                else
                {
                    iLength++;
                }
            }

            return iLength;
        }

        public int LengthOfLastWord_Naive2(string s)
        {
            int iLastWordLength = 0;
            int iCurrentWordLength = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ')
                {
                    if (iCurrentWordLength != 0)
                    {
                        iLastWordLength = iCurrentWordLength;
                    }

                    iCurrentWordLength = 0;
                }
                else
                {
                    iCurrentWordLength++;
                }
            }

            if (iCurrentWordLength != 0)
                iLastWordLength = iCurrentWordLength;

            return iLastWordLength;
        }

        public int LengthOfLastWord_Naive(string s)
        {
            var arrWords = s.TrimEnd(' ').Split(' ');
            return arrWords[arrWords.Length - 1].Length;
        }
    }
}
