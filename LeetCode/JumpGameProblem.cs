using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class JumpGameProblem
    {
        // https://leetcode.com/problems/jump-game/?envType=study-plan-v2&envId=top-interview-150
        public bool CanJump(int[] nums)
        {
            var dct = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length - 1; i++) 
            {
                if (nums[i] == 0)
                {
                    return false;
                }

                if (i + nums[i] >= nums.Length - 1)
                {
                    return true;
                }

                foreach (int j in Enumerable.Range(1, nums[i]))
                {
                    dct.Add(i + j, nums[i + j] + j);
                }

                var max = dct.Aggregate((l, r) => l.Value > r.Value ? l : r);
                dct.Clear();

                i = max.Key - 1;
            }

            return true;
        }
    }
}
