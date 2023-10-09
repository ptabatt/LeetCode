using LeetCode;
using NUnit.Framework;

namespace LeetCodeUnitTest
{
    [TestFixture]
    public class ProductExceptItselfTest
    {
        [TestCase(new[] { 1, 2, 3, 4 }, new[] { 24, 12, 8, 6 })]
        [TestCase(new[] { -1, 1, 0, -3, 3 }, new[] { 0, 0, 9, 0, 0 })]
        public void ProductExeceptIteselfTest_Naive(int[] input, int[] expected)
        {
            var sut = new ProductExeceptItselfProblem();

            var actual = sut.ProductExceptSelf_Naive(input);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new[] { 1, 2, 3, 4 }, new[] { 24, 12, 8, 6 })]
        [TestCase(new[] { -1, 1, 0, -3, 3 }, new[] { 0, 0, 9, 0, 0 })]
        public void ProductExeceptIteselfTest(int[] input, int[] expected)
        {
            var sut = new ProductExeceptItselfProblem();

            var actual = sut.ProductExceptSelf(input);

            Assert.AreEqual(expected, actual);
        }
    }
}