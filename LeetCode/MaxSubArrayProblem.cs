using System;

namespace LeetCode
{
    public class MaxSubArrayProblem
    {
        public int MaxSubArray(int[] nums)
        {
            int iCurrentSubArray = nums[0];
            int iMaxSubArray = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                var num = nums[i];
                iCurrentSubArray = Math.Max(num, iCurrentSubArray + num);
                iMaxSubArray = Math.Max(iCurrentSubArray, iMaxSubArray);
            }

            return iMaxSubArray;
        }

        public int MaxSubArray_Naive(int[] nums)
        {
            int iHighestSum = nums[0];

            for (int i = 0; i < nums.Length; i++)
            {
                int iLoopSum = nums[i];

                if (iLoopSum > iHighestSum)
                    iHighestSum = iLoopSum;

                for (int j = i + 1; j < nums.Length; j++)
                {
                    iLoopSum += nums[j];

                    if (iLoopSum > iHighestSum)
                        iHighestSum = iLoopSum;
                }
            }

            return iHighestSum;
        }
    }
}
