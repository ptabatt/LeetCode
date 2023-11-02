using LeetCode;
using NUnit.Framework;
using System.Collections.Generic;

namespace LeetCodeUnitTest
{
    [TestFixture]
    public class SpiralMatrixTest
    {
        [Test]
        public void SpiralMatrixTestLeetCodeCase1()
        {
            var sut = new SpiralMatrixProblem();
            var given = new int[][] 
            { 
                new int[] { 1,2,3 }, 
                new int[] { 4,5,6 }, 
                new int[] { 7,8,9 } 
            };
            var expected = new List<int> { 1, 2, 3, 6, 9, 8, 7, 4, 5 };

            Assert.AreEqual(expected, sut.SpiralOrder(given));
        }

        [Test]
        public void SpiralMatrixTestLeetCodeCase2()
        {
            var sut = new SpiralMatrixProblem();
            var given = new int[][]
            {
                new int[] { 1,2,3,4 },
                new int[] { 5,6,7,8 },
                new int[] { 9,10,11,12 }
            };
            var expected = new List<int> { 1, 2, 3, 4, 8, 12, 11, 10, 9, 5, 6, 7 };

            Assert.AreEqual(expected, sut.SpiralOrder(given));
        }

        [Test]
        public void SpiralMatrixTestEdgeCase1()
        {
            // per instructions, we can't have a null or empty array as input, so
            // we won't be testing for that here
            var sut = new SpiralMatrixProblem();
            var given = new int[][]
            {
                new int[] { 100 }
            };
            var expected = new List<int> { 100 };

            Assert.AreEqual(expected, sut.SpiralOrder(given));
        }

        [Test]
        public void SpiralMatrixTestEdgeCase2()
        {
            var sut = new SpiralMatrixProblem();
            var given = new int[][]
            {
                new int[] { 100, 200, 100, 400 }
            };
            var expected = new List<int> { 100, 200, 100, 400 };

            Assert.AreEqual(expected, sut.SpiralOrder(given));
        }

        [Test]
        public void SpiralMatrixTestEdgeCase3()
        {
            var sut = new SpiralMatrixProblem();
            var given = new int[][]
            {
                new int[] { 100 },
                new int[] { 200 },
                new int[] { 100 },
                new int[] { 400 },
            };
            var expected = new List<int> { 100, 200, 100, 400 };

            Assert.AreEqual(expected, sut.SpiralOrder(given));
        }
    }
}
