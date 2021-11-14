using NUnit.Framework;
using LeetCode;

namespace LeetCodeUnitTest
{
    [TestFixture]
    public class RomanToInTest
    {
        [Test]
        public void RomanToIntBasicTest()
        {
            var sut = new RomanToIntegerProblem();

            Assert.AreEqual(3, sut.RomanToInt("III"));
            Assert.AreEqual(4, sut.RomanToInt("IV"));
            Assert.AreEqual(9, sut.RomanToInt("IX"));
            Assert.AreEqual(58, sut.RomanToInt("LVIII"));
            Assert.AreEqual(1994, sut.RomanToInt("MCMXCIV"));
        }
    }
}
