using LeetCode;
using NUnit.Framework;

namespace LeetCodeUnitTest
{
    [TestFixture]
    public class PascalsTriangleTest
    {
        [Test]
        public void PascalsTriangle_BasicTest()
        {
            var sut = new PascalsTriangleProblem();

            var colResult = sut.Generate(6);

            Assert.AreEqual(6, colResult.Count);

            var colLast = colResult[5];

            Assert.AreEqual(6, colLast.Count);
            Assert.AreEqual(1, colLast[0]);
            Assert.AreEqual(5, colLast[1]);
            Assert.AreEqual(10, colLast[2]);
            Assert.AreEqual(10, colLast[3]);
            Assert.AreEqual(5, colLast[4]);
            Assert.AreEqual(1, colLast[5]);
        }
    }
}
