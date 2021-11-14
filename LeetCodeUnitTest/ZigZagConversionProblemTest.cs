using LeetCode;
using NUnit.Framework;

namespace LeetCodeUnitTest
{
    [TestFixture]
    public class ZigZagConversionProblemTest
    {
        [Test]
        public void ZigZagConversion_BasicTest()
        {
            var sut = new ZigZagConversionProblem();

            Assert.AreEqual("AEBDFCG", sut.Convert("ABCDEFG", 3));
            Assert.AreEqual("PAHNAPLSIIGYIR", sut.Convert("PAYPALISHIRING", 3));
            Assert.AreEqual("PINALSIGYAHRPI", sut.Convert("PAYPALISHIRING", 4));
            Assert.AreEqual("A", sut.Convert("A", 1));
        }
    }
}
