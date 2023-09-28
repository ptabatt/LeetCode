using LeetCode;
using NUnit.Framework;

namespace LeetCodeUnitTest
{
    [TestFixture]
    public class MergeSortedArrayTest
    {
        [Test]
        public void PassByReference_Test()
        {
            var sut = new MergeSortedArrayProblem();
            int[] arr1 = new[] { 1, 2, 3, 0, 0, 0 };
            int[] arr2 = new[] { 1, 2, 3 };

            sut.Merge(arr1, 6, arr2, 3);

            Assert.AreEqual(3, arr1[5]);
        }

        [TestCase(new[] { 1, 2, 3, 0, 0, 0 }, 3, new[] { 2, 5, 6 }, 3, new[] { 1, 2, 2, 3, 5, 6 })]
        [TestCase(new[] { 1 }, 1, new int[] { }, 0, new[] { 1 })]
        [TestCase(new int[] { 0 }, 0, new [] { 1 }, 1, new[] { 1 })]
        [TestCase(new int[] { -1, 0, 0, 3, 3, 3, 0, 0, 0 }, 6, new[] { 1, 2, 2 }, 3, new[] { -1, 0, 0, 1, 2, 2, 3, 3, 3 })]
        [TestCase(new[] { 0, 0, 3, 0, 0, 0, 0, 0, 0 }, 3, new int[] { -1, 1, 1, 1, 2, 3 }, 6, new[] { -1, 0, 0, 1, 1, 1, 2, 3, 3 })]
        public void MergeSortedArray_BasicTests(int[] nums1, int m, int[] nums2, int n, int[] expected)
        {
            var sut = new MergeSortedArrayProblem();
            sut.Merge(nums1, m, nums2, n);

            Assert.AreEqual(expected, nums1);
        }
    }
}
