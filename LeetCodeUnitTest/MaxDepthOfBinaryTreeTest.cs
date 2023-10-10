using NUnit.Framework;
using LeetCode;

namespace LeetCodeUnitTest
{
    [TestFixture]
    public class MaxDepthOfBinaryTreeTest
    {
        [Test]
        public void MaxDepthOfBinaryTree_BasicExample()
        {
            var objSut = new MaxDepthOfBinaryTreeProblem();

            var root = new TreeNode
            {
                val = 3,
                left = new TreeNode
                {
                    val = 9
                },
                right = new TreeNode
                {
                    val = 20,
                    left = new TreeNode
                    {
                        val = 15
                    },
                    right = new TreeNode
                    {
                        val = 7
                    }
                }
            };

            Assert.AreEqual(3, objSut.MaxDepth(root));
        }

        [Test]
        public void MaxDepthOfBinaryTree_SingleNode()
        {
            var objSut = new MaxDepthOfBinaryTreeProblem();

            var root = new TreeNode
            {
                val = 5,
            };

            Assert.AreEqual(1, objSut.MaxDepth(root));
        }

        [Test]
        public void MaxDepthOfBinaryTree_TwoNodes()
        {
            var objSut = new MaxDepthOfBinaryTreeProblem();

            var root = new TreeNode
            {
                val = 5,
                right = new TreeNode
                {
                    val = 7
                }
            };

            Assert.AreEqual(2, objSut.MaxDepth(root));
        }

        [Test]
        public void MaxDepthOfBinaryTree_NullRoot()
        {
            var objSut = new MaxDepthOfBinaryTreeProblem();

            Assert.AreEqual(0, objSut.MaxDepth(null));
        }
    }
}
