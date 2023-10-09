using System.Collections.Generic;

namespace LeetCode
{
    public class SummaryRangeProblem
    {
        //You are given a sorted unique integer array nums.

        //A range[a, b] is the set of all integers from a to b(inclusive).

        //Return the smallest sorted list of ranges that cover all the numbers in the array exactly.
        //That is, each element of nums is covered by exactly one of the ranges, and there 
        //is no integer x such that x is in one of the ranges but not in nums.

        //Each range[a, b] in the list should be output as:

        //"a->b" if a != b
        //"a" if a == b
        public IList<string> SummaryRanges(int[] nums)
        {
            var result =  new List<string>();

            if (nums.Length == 0)
            {
                return result;
            }

            var sequenceBegin = nums[0];
            var sequenceEnd = nums[0];

            for (int i = 1; i <= nums.Length; i++)
            {
                if (i == nums.Length)
                {
                    if (sequenceBegin == sequenceEnd)
                    {
                        result.Add($"{sequenceBegin}");
                    }
                    else
                    {
                        result.Add($"{sequenceBegin}->{sequenceEnd}");
                    }
                }
                else if (nums[i] - 1 == sequenceEnd)
                {
                    sequenceEnd = nums[i];
                }
                else
                {
                    if (sequenceBegin == sequenceEnd)
                    {
                        result.Add($"{sequenceBegin}");
                    }
                    else
                    {
                        result.Add($"{sequenceBegin}->{sequenceEnd}");
                    }

                    sequenceBegin = nums[i];
                    sequenceEnd = nums[i];
                }
            }

            return result;
        }
    }
}
