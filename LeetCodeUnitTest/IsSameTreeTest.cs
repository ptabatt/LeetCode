using LeetCode;
using NUnit.Framework;

namespace LeetCodeUnitTest
{
    [TestFixture]
    public class IsSameTreeTest
    {
        [Test]
        public void SameTree_BasicTest()
        {
            var objSut = new SameTreeProblem();

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

            var dupe = new TreeNode
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

            Assert.IsTrue(objSut.IsSameTree(root, dupe));
        }

        [Test]
        public void NotSameTree_BasicTest()
        {
            var objSut = new SameTreeProblem();

            var root = new TreeNode
            {
                val = 1,
                left = new TreeNode
                {
                    val = 2,
                }
            };

            var notDupe = new TreeNode
            {
                val = 1,
                right = new TreeNode
                {
                    val = 2,
                }
            };

            Assert.IsFalse(objSut.IsSameTree(root, notDupe));
        }
    }
}
