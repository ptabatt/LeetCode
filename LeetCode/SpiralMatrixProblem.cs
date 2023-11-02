using System.Collections.Generic;

namespace LeetCode
{
    public class SpiralMatrixProblem
    {
        public enum Direction { Right, Down, Left, Up }
        public IList<int> SpiralOrder(int[][] matrix)
        {
            var col = new List<int>();
            var m = matrix[0].Length;
            var n = matrix.Length;
            var cellCount =  m * n;
            var d = Direction.Right;
            var offSet = 0;
            int i = 0, x = 0, y = 0;            

            while (i < cellCount)
            {
                col.Add(matrix[y][x]);
                i++;

                switch (d)
                {
                    case Direction.Right:
                        if (x < (m - 1 - offSet))
                        {
                            x++;
                        }
                        else
                        {
                            y++;
                            d = Direction.Down;
                        }
                        break;
                    case Direction.Down:
                        if (y < (n - 1 - offSet))
                        {
                            y++;
                        }
                        else
                        {
                            x--;
                            d = Direction.Left;
                        }
                        break;
                    case Direction.Left:
                        if (x > offSet)
                        {
                            x--;
                        }
                        else
                        {
                            y--;
                            d = Direction.Up;
                        }
                        break;
                    case Direction.Up:
                        if (y > offSet + 1)
                        {
                            y--;
                        }
                        else
                        {
                            x++;
                            d = Direction.Right;
                            // IMPORTANT: the height and width of the rectangle shrinks
                            // when it's time to go to the right again.
                            offSet++;
                        }
                        break;
                    default:
                        break;
                }
            }

            return col;
        }
    }
}
