using System.Text;

namespace LeetCode
{
    public class MergeStringsAlternatelyProblem
    {
        // https://leetcode.com/problems/merge-strings-alternately/
        public string MergeAlternately(string word1, string word2)
        {
            var sb = new StringBuilder();

            for (int i = 0; i < word1.Length + word2.Length; i++)
            {
                if (i % 2 == 0)
                {
                    int idx = i / 2;
                    
                    if (idx < word1.Length)
                    {
                        sb.Append(word1[idx]);
                    }
                    else
                    {
                        while (idx < word2.Length)
                        {
                            sb.Append(word2[idx]);
                            idx++;
                        }

                        break;
                    }
                }
                else
                {
                    int idx = (i - 1) / 2;

                    if (idx < word2.Length)
                    {
                        sb.Append(word2[idx]);
                    }
                    else
                    {
                        while (idx < word1.Length - 1)
                        {
                            idx++;
                            sb.Append(word1[idx]);
                        }

                        break;
                    }
                }
            }

            return sb.ToString();
        }
    }
}
