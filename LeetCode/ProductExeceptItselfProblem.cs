using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class ProductExeceptItselfProblem
    {
        //Given an integer array nums, return an array answer such that answer[i] is equal to
        //the product of all the elements of nums except nums[i].

        //The product of any prefix or suffix of nums is guaranteed to fit in a 32-bit integer.

        //You must write an algorithm that runs in O(n) time and without using the division operation.

        //Constraints:
        //2 <= nums.length <= 105
        //-30 <= nums[i] <= 30
        //The product of any prefix or suffix of nums is guaranteed to fit in a 32-bit integer.

        public int[] ProductExceptSelf_Naive(int[] nums)
        {
            int?[] arrOfNulls = new int?[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }
                    else if (arrOfNulls[i] == null)
                    {
                        arrOfNulls[i] = nums[j];
                    }
                    else
                    {
                        arrOfNulls[i] *= nums[j];
                    }
                }
            }

            int[] result = new int[arrOfNulls.Length];
            for (int i = 0; i < arrOfNulls.Length; i++)
            {
                result[i] = arrOfNulls[i] == null ? 0 : arrOfNulls[i].Value;
            }

            return result;
        }

        public int[] ProductExceptSelf(int[] nums)
        {
            var prefProd = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                if (i == 0)
                {
                    prefProd[i] = 1;
                } 
                else
                {
                    prefProd[i] = nums[i - 1] * prefProd[i - 1];
                }
            }

            var suffProd = new int[nums.Length];

            for (int i = nums.Length - 1; i >= 0; i--)
            {
                if (i == nums.Length - 1)
                {
                    suffProd[i] = 1;
                } 
                else
                {
                    suffProd[i] = nums[i + 1] * suffProd[i + 1];
                }
            }

            var result = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                result[i] = prefProd[i] * suffProd[i];
            }

            return result;
        }   
    }
}
