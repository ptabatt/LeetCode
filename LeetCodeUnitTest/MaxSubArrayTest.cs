using NUnit.Framework;
using LeetCode;

namespace LeetCodeUnitTest
{
    [TestFixture]
    public class MaxSubArrayTest
    {
        [Test]
        public void MaxSubArray_BasicTest()
        {
            var sut = new MaxSubArrayProblem();

            Assert.AreEqual(6, sut.MaxSubArray(new[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 }));
            Assert.AreEqual(1, sut.MaxSubArray(new[] { 1 }));
            Assert.AreEqual(23, sut.MaxSubArray(new[] { 5, 4, -1, 7, 8 }));
            Assert.AreEqual(1, sut.MaxSubArray(new[] { -2, 1 }));
            Assert.AreEqual(5, sut.MaxSubArray(new[] { 5, -1 }));
            Assert.AreEqual(-1, sut.MaxSubArray(new[] { -1 }));

            Assert.AreEqual(6, sut.MaxSubArray_Naive(new[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 }));
            Assert.AreEqual(1, sut.MaxSubArray_Naive(new[] { 1 }));
            Assert.AreEqual(23, sut.MaxSubArray_Naive(new[] { 5, 4, -1, 7, 8 }));
            Assert.AreEqual(1, sut.MaxSubArray_Naive(new[] { -2, 1 }));
            Assert.AreEqual(5, sut.MaxSubArray_Naive(new[] { 5, -1 }));
            Assert.AreEqual(-1, sut.MaxSubArray_Naive(new[] { -1 }));
        }
    }
}
