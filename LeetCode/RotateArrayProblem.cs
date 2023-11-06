using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class RotateArrayProblem
    {
        public void Rotate(int[] nums, int k)
        {
            if (nums.Length < 2 || k < 1)
            {
                return;
            }

            var n = nums.Length;
            var tmp = new int[n];

            if (k > n)
            {
                k %= n;
            }

            var ii = n - k;

            for (var i = 0; i < n; i++)
            {
                if (ii > n - 1)
                {
                    tmp[i] = nums[ii - n];
                }
                else
                {
                    tmp[i] = nums[ii];
                }

                ii++;
            }

            for (var i = 0; i < tmp.Length; i++)
            {
                nums[i] = tmp[i];
            }
        }
    }
}
