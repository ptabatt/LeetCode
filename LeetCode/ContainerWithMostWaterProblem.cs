using System;

namespace LeetCode
{
    public class ContainerWithMostWaterProblem
    {
        public int MaxArea(int[] height)
        {
            int iMaxArea = 0, l = 0, r = height.Length - 1;
             
            while (l < r)
            {
                iMaxArea = Math.Max(iMaxArea, Math.Min(height[l], height[r]) * (r - l));

                if (height[l] > height[r])
                    r--;
                else
                    l++;
            }

            return iMaxArea;
        }

        public int MaxAreaNaive(int[] height)
        {
            var iMaxArea = 0;

            for (int i = 0; i < height.Length; i++)
            {
                for (int j = 1; j < height.Length; j++)
                {
                    var iCurrentHeight = Math.Min(height[i], height[j]);
                    var iCurrentLength = j - i;

                    var iLoopArea = iCurrentHeight * iCurrentLength;
                    iMaxArea = Math.Max(iMaxArea, iLoopArea);
                }
            }

            return iMaxArea;
        }
    }
}
