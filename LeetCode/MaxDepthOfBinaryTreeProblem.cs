using System;

namespace LeetCode
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

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
