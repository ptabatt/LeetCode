using LeetCode;
using NUnit.Framework;

namespace LeetCodeUnitTest
{
    [TestFixture]
    public class RotateImageTest
    {
        [Test]
        public void RotateImageBasicTest1()
        {
            var objSut = new RotateImageProblem();

            var matrixInput = new int[][] 
            { 
                new[] { 1, 2, 3 },
                new[] { 4, 5, 6 },
                new[] { 7, 8, 9 } 
            };

            var matrixExpectedOutput = new int[][]
            {
                new[] { 7, 4, 1 },
                new[] { 8, 5, 2 },
                new[] { 9, 6, 3 }
            };

            objSut.Rotate(matrixInput);
            Assert.AreEqual(matrixExpectedOutput, matrixInput);
        }

        [Test]
        public void RotateImageBasicTest2()
        {
            var objSut = new RotateImageProblem();

            var matrixInput = new int[][]
            {
                new[] {5,1,9,11 }, 
                new[] {2, 4, 8, 10 }, 
                new[] {13, 3, 6, 7 }, 
                new[] {15, 14, 12, 16 }
            };

            var matrixExpectedOutput = new int[][]
            {
                new[] {15,13,2,5 },
                new[] {14,3,4,1 },
                new[] {12,6,8,9 },
                new[] { 16, 7, 10, 11 }
            };

            objSut.Rotate(matrixInput);
            Assert.AreEqual(matrixExpectedOutput, matrixInput);
        }
    }
}
