using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class MajorityElementProblem
    {
        //Given an array nums of size n, return the majority element.
        //The majority element is the element that appears more than ⌊n / 2⌋ times.
        //You may assume that the majority element always exists in the array.
        public int MajorityElement(int[] nums)
        {
            var dct = new Dictionary<int, int>();

            for(int i = 0; i < nums.Length; i++)
            {
                if (dct.ContainsKey(nums[i]))
                    dct[nums[i]] += 1;
                else
                    dct[nums[i]] = 1;
            }

            return dct.OrderByDescending(x => x.Value).First().Key;
        }
    }
}