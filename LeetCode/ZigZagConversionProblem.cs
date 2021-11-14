using System.Text;

namespace LeetCode
{
    public class ZigZagConversionProblem
    {
        public string Convert(string s, int numRows)
        {
            if (numRows == 1)
                return s;

            var iRowLength = s.Length;
            var iColumnLength = numRows;

            char[,] twoDCharArray = new char[iRowLength, iColumnLength];
            
            int x = 0, y = 0;

            for (int i = 0; i < s.Length; i++)
            {
                twoDCharArray[x, y] = s[i];

                if ((x % (iColumnLength - 1)) == 0)
                {
                    if (y == (iColumnLength - 1))
                    {
                        x++;
                        y--;
                    }
                    else
                    {
                        y++;
                    }
                }
                else
                {
                    x++;
                    y--;
                }
            }
            
            var strResult = PrintTwoDimensionalCharArray(twoDCharArray, iRowLength, iColumnLength);
            return strResult;
        }

        private string PrintTwoDimensionalCharArray(char[,] twoDCharArray,
            int iRowLength, int iColumnLength)
        {
            var sb = new StringBuilder();

            int x = 0, y = 0;

            while (x < iRowLength && y < iColumnLength)
            {
                var c = twoDCharArray[x, y];
                if (c != '\0')
                {
                    sb.Append(c);
                }

                if (x == iRowLength - 1)
                {
                    x = 0;
                    y++;
                }
                else
                {
                    x++;
                }
            }

            return sb.ToString();
        }
    }
}