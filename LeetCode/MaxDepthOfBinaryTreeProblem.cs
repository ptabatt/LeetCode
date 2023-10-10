using System;

namespace LeetCode
{
    public class MaxDepthOfBinaryTreeProblem
    {
        public int MaxDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            int maxRight, maxLeft;
            if (root.left != null)
            {
                maxRight = MaxDepth(root.left) + 1;
            }
            else
            {
                maxRight = 0;
            }

            if (root.right != null)
            {
                maxLeft = MaxDepth(root.right) + 1;
            }
            else
            {
                maxLeft = 0;
            }

            return Math.Max(maxRight, Math.Max(maxLeft, 1));
        }
    }
}
