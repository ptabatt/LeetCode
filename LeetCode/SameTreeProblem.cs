using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class SameTreeProblem
    {
        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            throw new NotImplementedException();
        }

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

    }
}
