using LeetCode;
using NUnit.Framework;

namespace LeetCodeUnitTest
{
    [TestFixture]
    public class RotateArrayTest
    {
        [Test]
        public void RotateArrayExample1()
        {
            var sut = new RotateArrayProblem();
            var given = new[] { 1, 2, 3, 4, 5, 6, 7 };
            var expected = new[] { 5, 6, 7, 1, 2, 3, 4 };

            sut.Rotate(given, 3);

            Assert.AreEqual(expected, given);
        }

        [Test]
        public void RotateArrayExample2()
        {
            var sut = new RotateArrayProblem();
            var given = new[] { -1, -100, 3, 99 };
            var expected = new[] { 3, 99, -1, -100 };

            sut.Rotate(given, 2);

            Assert.AreEqual(expected, given);
        }

        [Test]
        public void RotateArrayExample3()
        {
            var sut = new RotateArrayProblem();
            var given = new[] { 1, 2, 3 };
            var expected = new[] { 3, 1, 2 };

            sut.Rotate(given, 1);

            Assert.AreEqual(expected, given);
        }

        [Test]
        public void RotateArrayEdgeCase1()
        {
            var sut = new RotateArrayProblem();
            var given = new[] { 1, 2 };
            var expected = new[] { 2, 1 };

            sut.Rotate(given, 3);

            Assert.AreEqual(expected, given);
        }

        [Test]
        public void RotateArrayEdgeCase2()
        {
            var sut = new RotateArrayProblem();
            var given = new[] { 1, 2, 3 };
            var expected = new[] { 3, 1, 2 };

            sut.Rotate(given, 4);

            Assert.AreEqual(expected, given);
        }
    }
}
