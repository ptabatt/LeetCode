using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class ThreeSumProblem
    {
        /// <summary>
        /// Given an integer array nums, return all the triplets 
        /// [nums[i], nums[j], nums[k]] such that i != j, i != k, and j != k, 
        /// and nums[i] + nums[j] + nums[k] == 0.
        ///
        /// Notice that the solution set must not contain duplicate triplets.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            var result = new List<IList<int>>();

            if (nums.Length < 3)
                return result;

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 1; j < nums.Length; j++)
                {
                    for (int k = 2; k < nums.Length; k++)
                    {
                        if (i == j || j == k || i == k)
                        {
                            //we don't want to use the same indices
                            continue;
                        }
                        else if (nums[i] + nums[j] + nums[k] == 0)
                        {
                            if (ResultSetAlreadyContains(result, nums[i], nums[j], nums[k]))
                            {
                                // we don't want to add duplicate correct answers
                                continue;
                            }

                            result.Add(new List<int>
                            {
                                nums[i],  nums[j], nums[k]
                            });
                        }
                    }
                }
            }

            return result;
        }
        
        private bool ResultSetAlreadyContains(List<IList<int>> result, int i, int j, int k)
        {
            foreach (var subResult in result)
            {
                var removed = new List<int>();

                if (subResult.Contains(i))
                {
                    subResult.Remove(i);
                    removed.Add(i);

                    if (subResult.Contains(j))
                    {
                        subResult.Remove(j);
                        removed.Add(j);

                        if (subResult.Contains(k))
                        {
                            subResult.Remove(k);
                            removed.Add(k);

                            foreach (var r in removed)
                            {
                                subResult.Add(r);
                            }

                            return true;
                        }
                    }
                }

                foreach (var r in removed)
                {
                    subResult.Add(r);
                }
            }

            return false;
        }
    }
}
