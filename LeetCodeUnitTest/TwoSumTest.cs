using LeetCode;
using NUnit.Framework;

namespace LeetCodeUnitTest
{
    [TestFixture]
    public class TwoSumTest
    {
        [Test]
        [TestCase(new[] { 2, 7, 11, 15 }, 9, 0, 1)]
        [TestCase(new[] { 3, 2, 4 }, 6, 1, 2)]
        [TestCase(new[] { 3, 3 }, 6, 0, 1)]
        public void TwoSumTest_Basic(int[] inputNums
            , int inputTarget
            , int expectedFirstArrayIndex
            , int expectedSecondArrayIndex)
        {
            var sut = new TwoSumProblem();
            var sutOutput = sut.TwoSum(inputNums, inputTarget);

            Assert.AreEqual(2, sutOutput.Length);
            Assert.AreEqual(expectedFirstArrayIndex, sutOutput[0]);
            Assert.AreEqual(expectedSecondArrayIndex, sutOutput[1]);
        }
    }
}
