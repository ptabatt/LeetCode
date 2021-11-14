using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCode
{
    public class BinarySearchProblem
    {
        /// <summary>
        /// Given an array of integers nums which is sorted in ascending order, 
        /// and an integer target, write a function to search target in nums. 
        /// If target exists, then return its index. Otherwise, return -1.
        /// You must write an algorithm with O(log n) runtime complexity.
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int Search(int[] nums, int target)
        {
            int result = BinarySearchRecursive(nums, target, 0, nums.Length - 1);

            if (result > -1)
                return result;

            return -1;
        }

        public int BinarySearchRecursive(int[] nums, int target, int leftIndex, int rightIndex)
        {
            if (leftIndex > rightIndex)
                return -1;

            int midIndex = (rightIndex + leftIndex) / 2;

            if (nums[midIndex] == target)
            {
                return midIndex;
            }
            else if (target > nums[midIndex])
            {
                return BinarySearchRecursive(nums, target, midIndex + 1, rightIndex);
            }
            else
            {
                return BinarySearchRecursive(nums, target, leftIndex, midIndex - 1);
            }
        }

        public int BinarySearchIterative(int[] nums, int target)
        {
            int leftIndex = 0;
            int rightIndex = nums.Length - 1;

            int midIndex;

            while (leftIndex <= rightIndex)
            {
                midIndex = (rightIndex + leftIndex) / 2;
                if (nums[midIndex] == target)
                {
                    return midIndex;
                }
                else if (target > nums[midIndex])
                {
                    leftIndex = midIndex + 1;
                }
                else
                {
                    rightIndex = midIndex - 1;
                }
            }
            return -1;
        }
    }
}
