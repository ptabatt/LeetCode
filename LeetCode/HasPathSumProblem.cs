using System;

namespace LeetCode
{
    // https://leetcode.com/problems/path-sum/description/?envType=study-plan-v2&envId=top-interview-150
    public class HasPathSumProblem
    {
        public bool HasPathSum(TreeNode root, int targetSum)
        {
            if (root == null)
            {
                return false;
            }

            if (root.left == null && root.right == null)
            {
                return root.val == targetSum;
            }

            return (root.left == null ? false : HasPathSum(root.left, targetSum - root.val))
                || (root.right == null ? false : HasPathSum(root.right, targetSum - root.val));
        }
    }
}
