using LeetCode;
using NUnit.Framework;

namespace LeetCodeUnitTest
{
    [TestFixture]
    public class MergeRangesTest
    {
        [Test]
        public void MergeRangesBasicTests()
        {
            var objSut = new MergeRangesProblem();

            var positive = new int[][] { new int[] { 1, 3 }, new int[] { 2, 4 }, new int[] { 7, 9 } };
            var expected = new int[][] { new int[] { 1, 4 }, new int[] { 7, 9 } };

            Assert.AreEqual(expected, objSut.MergeRanges(positive));

            var negative = new int[][] { new int[] { 1, 2 }, new int[] { 3, 4 } };

            Assert.AreEqual(negative, objSut.MergeRanges(negative));

            var unOrdered = new int[][] { new int[] { 2, 4 }, new int[] { 1, 3 }, new int[] { 7, 9 } };

            Assert.AreEqual(expected, objSut.MergeRanges(unOrdered));

            var boundary = new int[][] { new int[] { 1, 3 }, new int[] { 3, 4 }, new int[] { 7, 9 } };

            Assert.AreEqual(expected, objSut.MergeRanges(boundary));
        }
    }
}
