using LeetCode;
using NUnit.Framework;

namespace LeetCodeUnitTest
{
    [TestFixture]
    public class MergeRangesTest
    {
        [Test]
        public void MergeRangesBasicTestPositive()
        {
            var objSut = new MergeRangesProblem();

            var positive = new int[][] { new int[] { 1, 3 }, new int[] { 2, 4 }, new int[] { 7, 9 } };
            var expected = new int[][] { new int[] { 1, 4 }, new int[] { 7, 9 } };

            Assert.AreEqual(expected, objSut.Merge(positive));
        }

        [Test]
        public void MergeRangesBasicTestNegative()
        {
            var objSut = new MergeRangesProblem();

            var negative = new int[][] { new int[] { 1, 2 }, new int[] { 3, 4 } };

            Assert.AreEqual(negative, objSut.Merge(negative));
        }

        [Test]
        public void MergeRangesBasicTestUnordered()
        {
            var objSut = new MergeRangesProblem();

            var unOrdered = new int[][] { new int[] { 2, 4 }, new int[] { 1, 3 }, new int[] { 7, 9 } };
            var expected = new int[][] { new int[] { 1, 4 }, new int[] { 7, 9 } };

            Assert.AreEqual(expected, objSut.Merge(unOrdered));
        }

        [Test]
        public void MergeRangesBasicTestBoundary()
        {
            var objSut = new MergeRangesProblem();

            var boundary = new int[][] { new int[] { 1, 3 }, new int[] { 3, 4 }, new int[] { 7, 9 } };
            var expected = new int[][] { new int[] { 1, 4 }, new int[] { 7, 9 } };

            Assert.AreEqual(expected, objSut.Merge(boundary));
        }

        [Test]
        public void MergeRangesBasicTestEncapsulated()
        {
            var objSut = new MergeRangesProblem();

            var encapsulated = new int[][] { new int[] { 1, 4 }, new int[] { 2, 3 } };

            Assert.AreEqual(new int[][] { new int[] { 1, 4 } }, objSut.Merge(encapsulated));
        }
    }
}
