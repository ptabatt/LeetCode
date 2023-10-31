using System;

namespace LeetCode
{
    // https://leetcode.com/problems/longest-consecutive-sequence/description/?envType=study-plan-v2&envId=top-interview-150

    public class LongestConsecutiveSequenceProblem
    {
        public int LongestConsecutive(int[] nums)
        {
            if (nums.Length == 0)
                return 0;

            Array.Sort(nums);

            int record = 1, current = 1;

            for (int i = 1; i < nums.Length; i++)
            {
                if ((nums[i] - 1) == nums[i - 1])
                {
                    current++;
                    if (current > record)
                    {
                        record = current;
                    }
                }
                else if (nums[i] == nums[i - 1])
                {
                    continue;
                }
                else
                {
                    current = 1;
                }
            }

            return record;
        }
    }
}
