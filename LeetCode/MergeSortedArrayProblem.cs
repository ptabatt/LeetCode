using System.Collections.Generic;

namespace LeetCode
{
    public class MergeSortedArrayProblem
    {
        //You are given two integer arrays nums1 and nums2, sorted in non-decreasing order,
        //and two integers m and n, representing the number of elements in nums1 and nums2 respectively.

        //Merge nums1 and nums2 into a single array sorted in non-decreasing order.

        //The final sorted array should not be returned by the function, but instead be stored
        //inside the array nums1. To accommodate this, nums1 has a length of m + n, where the first m elements
        //denote the elements that should be merged, and the last n elements are set to 0 and should be ignored.
        //nums2 has a length of n.

        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            var lst = new List<int>();
            for (int i = 0; i < m; i++)
            {   
                lst.Add(nums1[i]);
            }
            foreach (var num in nums2)
            {
                lst.Add(num);
            }

            lst.Sort();
            var nums3 = lst.ToArray();

            for (int i=0; i <= nums3.Length - 1; i++)
            {
                nums1[i] = nums3[i];
            }
        }
    }
}
