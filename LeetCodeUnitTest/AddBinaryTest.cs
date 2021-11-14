using LeetCode;
using NUnit.Framework;

namespace LeetCodeUnitTest
{
    [TestFixture]
    public class AddBinaryTest
    {
        [Test]
        public void BinaryToInt_BasicTest()
        {
            var sut = new AddBinaryProblem();

            Assert.AreEqual(9, sut.BinaryToInt("1001"));
            Assert.AreEqual(1, sut.BinaryToInt("1"));
            Assert.AreEqual(3, sut.BinaryToInt("11"));
            Assert.AreEqual(135, sut.BinaryToInt("10000111"));
        }

        [Test]
        public void IntToBinary_BasicTest()
        {
            var sut = new AddBinaryProblem();

            Assert.AreEqual("1001", sut.IntToBinary(9));
            Assert.AreEqual("1", sut.IntToBinary(1));
            Assert.AreEqual("11", sut.IntToBinary(3));
            Assert.AreEqual("10000111", sut.IntToBinary(135));
        }

        [Test]
        public void AddBinary_BasicTest()
        {
            var sut = new AddBinaryProblem();

            Assert.AreEqual("0", sut.AddBinary("0", "0"));
            Assert.AreEqual("101", sut.AddBinary("100", "1"));
            Assert.AreEqual("1000", sut.AddBinary("111", "1"));
        }
    }
}
