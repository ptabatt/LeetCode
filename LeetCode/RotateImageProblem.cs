using System;

namespace LeetCode
{
    public class RotateImageProblem
    {
        // https://leetcode.com/problems/rotate-image/?envType=study-plan-v2&envId=top-interview-150
        public void Rotate(int[][] matrix)
        {
            var n = matrix.Length;
            if (n <= 1)
            {
                return;
            }

            // Create algorithm to traverse matrix border and rotate columns/rows
            // Run the algorithm m times where m = the floor of n / 2 (we're using an n x n grid here)

            for (var i = 0; i < Math.Floor(new decimal(n/2)); i++)
            {
                var firstIdx = i;
                var lastIdx = n - 1 - i;

                var tmpArrIdx = 0;

                // put top row in right column

                var tmpArr = CreateTmpArrFromSubMatrix(matrix[i], i);

                for (var currentRowIdx = firstIdx; currentRowIdx <= lastIdx; currentRowIdx++)
                {
                    Swap(matrix, currentRowIdx, lastIdx, tmpArr, tmpArrIdx);
                    tmpArrIdx++;
                }

                tmpArrIdx = 0;

                // put left column in bottom row (but in reverse)

                Array.Reverse(tmpArr);

                for (var currentColIdx = firstIdx; currentColIdx <= lastIdx; currentColIdx++)
                {
                    Swap(matrix, lastIdx, currentColIdx, tmpArr, tmpArrIdx);
                    tmpArrIdx++;
                }

                tmpArrIdx = 1;

                // put bottom row in left column (but in reverse)

                Array.Reverse(tmpArr);

                for (var currentRowIdx = lastIdx - 1; currentRowIdx >= firstIdx; currentRowIdx--)
                {
                    Swap(matrix, currentRowIdx, firstIdx, tmpArr, tmpArrIdx);
                    tmpArrIdx++;
                }

                tmpArrIdx = 1;

                // put right column in top row

                Array.Reverse(tmpArr);

                for (var currentColIdx = lastIdx - 1; currentColIdx > firstIdx; currentColIdx--)
                {
                    Swap(matrix, firstIdx, currentColIdx, tmpArr, tmpArrIdx);
                    tmpArrIdx++;
                }
            }
        }

        int[] CreateTmpArrFromSubMatrix(int[] subMatrix, int offset)
        {
            var offSetTimes2 = offset * 2;
            var tmpArr = new int[subMatrix.Length - offSetTimes2];

            for (var i = 0; i < subMatrix.Length - offSetTimes2; i++)
            {
                tmpArr[i] = subMatrix[i + offset];
            }

            return tmpArr;
        }

        void Swap(int[][] matrix, int rowIdx1, int colIdx1, int[] arr, int arrIdx)
        {
            var tmp = matrix[rowIdx1][colIdx1];
            matrix[rowIdx1][colIdx1] = arr[arrIdx];
            arr[arrIdx] = tmp;
        }
    }
}
