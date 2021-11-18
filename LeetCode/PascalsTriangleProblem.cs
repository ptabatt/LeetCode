using System.Collections.Generic;

namespace LeetCode
{
    public class PascalsTriangleProblem
    {
        /// <summary>
        /// Given an integer numRows, return the first numRows of Pascal's triangle.
        /// </summary>
        /// <param name="numRows"></param>
        /// <returns></returns>
        public IList<IList<int>> Generate(int numRows)
        {
            var colTriangle = new List<IList<int>>();

            for (int i = 1; i <= numRows; i++)
            {
                var colRow = new List<int>();

                for (int j = 1; j <= i; j++)
                {
                    if (j == 1)
                    {
                        //Each Row begins with 1 no matter what
                        colRow.Add(1);
                    }
                    else if (j == i)
                    {
                        //Each row (besides the first) ends with 1 no matter what
                        colRow.Add(1);
                    }
                    else
                    {
                        var entry = colTriangle[i-2][j-1] 
                            + colTriangle[i-2][j-2];
                        colRow.Add(entry);
                    }
                }

                colTriangle.Add(colRow);
            }

            return colTriangle;
        }
    }
}
