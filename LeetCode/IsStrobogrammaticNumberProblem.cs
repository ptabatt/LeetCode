using System.Linq;
using System.Text;

namespace LeetCode
{
    public class IsStrobogrammaticProblem
    {
        //https://leetcode.com/problems/strobogrammatic-number/
        public bool IsStrobogrammatic(string num)
        {
            var sb = new StringBuilder();

            foreach (var c in num)
            {
                switch (c)
                {
                    case '0':
                    case '1':
                    case '8':
                        sb.Append(c);
                        break;
                    case '6':
                        sb.Append('9');
                        break;
                    case '9':
                        sb.Append('6');
                        break;
                    default:
                        return false;
                }
            }

            var reversed = new string(sb.ToString().Reverse().ToArray());
            return Equals(reversed, num);
        }
    }
}
