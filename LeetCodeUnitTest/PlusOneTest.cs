using NUnit.Framework;
using LeetCode;

namespace LeetCodeUnitTest
{
    [TestFixture]
    public class PlusOneTest
    {
        [Test]
        public void PlusOneBasicTest()
        {
            var sut = new PlusOneProblem();

            var result = sut.PlusOne(new[] { 1, 2, 3 });

            Assert.AreEqual(3, result.Length);
            Assert.AreEqual(1, result[0]);
            Assert.AreEqual(2, result[1]);
            Assert.AreEqual(4, result[2]);

            result = sut.PlusOne(new[] { 9 });

            Assert.AreEqual(2, result.Length);
            Assert.AreEqual(1, result[0]);
            Assert.AreEqual(0, result[1]);

            result = sut.PlusOne(new[] { 9, 9, 9 });
            Assert.AreEqual(4, result.Length);
            Assert.AreEqual(1, result[0]);
            Assert.AreEqual(0, result[1]);
            Assert.AreEqual(0, result[2]);
            Assert.AreEqual(0, result[3]);
        }
    }
}
