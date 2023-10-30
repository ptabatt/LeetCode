using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class IsValidSudokuProblem
    {
        // https://leetcode.com/problems/valid-sudoku/?envType=study-plan-v2&envId=top-interview-150
        public bool IsValidSudoku(char[][] board)
        {
            for (int i = 0; i < 9; i++)
            {
                var row = Enumerable.Range(0, 9)
                    .Select(x => board[i][x])
                    .ToArray();

                if (!IsValidSegment(row))
                {
                    return false;
                }

                var column = Enumerable.Range(0, 9)
                    .Select(x => board[x][i])
                    .ToArray();

                if (!IsValidSegment(column))
                {
                    return false;
                }

                if (i % 3 == 0)
                {
                    for (int j = 0; j < 9; j+=3)
                    {
                        var miniSquare = new List<char>();
                        for (int k = 0; k < 3; k++)
                        {
                            miniSquare.Add(board[i + k][j]);
                            miniSquare.Add(board[i + k][j + 1]);
                            miniSquare.Add(board[i + k][j + 2]);
                        }

                        if (!IsValidSegment(miniSquare.ToArray()))
                        {
                            return false;
                        }
                    }
                }
            }

            return true;
        }

        bool IsValidSegment(char[] segment)
        {
            var segmentDct = new Dictionary<char, int>();

            foreach (var c in segment)
            {
                if (c == '.')
                {
                    continue;
                }

                if (segmentDct.ContainsKey(c))
                {
                    return false;
                }

                segmentDct.Add(c, 1);
            }

            return true;
        }
    }
}
