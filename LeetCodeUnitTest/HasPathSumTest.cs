using LeetCode;
using NUnit.Framework;

namespace LeetCodeUnitTest
{
    [TestFixture]
    public class HasPathSumTest
    {
        [Test]
        public void HasPathSumLeetCodeExample1()
        {
            var sut = new HasPathSumProblem();

            var root = new TreeNode
            {
                val = 5,
                left = new TreeNode
                {
                    val = 4,
                    left = new TreeNode
                    {
                        val = 11,
                        left = new TreeNode
                        {
                            val = 7
                        },
                        right = new TreeNode
                        {
                            val = 2
                        }
                    }
                },
                right = new TreeNode
                {
                    val = 8,
                    left = new TreeNode
                    {
                        val = 13
                    },
                    right = new TreeNode
                    {
                        val = 4,
                        right = new TreeNode
                        {
                            val = 1
                        }
                    }
                }
            };

            Assert.IsTrue(sut.HasPathSum(root, 22));
        }

        [Test]
        public void HasPathSumLeetCodeExample2()
        {
            var sut = new HasPathSumProblem();

            var root = new TreeNode
            {
                val = 1,
                left = new TreeNode
                {
                    val = 2
                },
                right = new TreeNode
                {
                    val = 3
                }
            };

            Assert.IsFalse(sut.HasPathSum(root, 5));
        }

        [Test]
        public void HasPathSumSimpleExample()
        {
            var sut = new HasPathSumProblem();

            var root = new TreeNode
            {
                val = 1,
                left = new TreeNode
                {
                    val = 2
                },
            };

            Assert.IsTrue(sut.HasPathSum(root, 3));
        }

        [Test]
        public void HasPathSumNullExample()
        {
            var sut = new HasPathSumProblem();

            Assert.IsFalse(sut.HasPathSum(null, 0));
        }
    }
}
