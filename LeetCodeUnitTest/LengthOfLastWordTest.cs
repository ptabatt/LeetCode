using LeetCode;
using NUnit.Framework;

namespace LeetCodeUnitTest
{
    [TestFixture]
    public class LengthOfLastWordTest
    {
        [Test]
        public void LengthOfLastWord_BasicTest()
        {
            var sut = new LengthOfLastWordProblem();

            Assert.AreEqual(3, sut.LengthOfLastWord("car"));
            Assert.AreEqual(5, sut.LengthOfLastWord("Hello World"));
            Assert.AreEqual(5, sut.LengthOfLastWord("Hell World "));
            Assert.AreEqual(5, sut.LengthOfLastWord(" Hello World"));
            Assert.AreEqual(5, sut.LengthOfLastWord("ello World  "));
            Assert.AreEqual(5, sut.LengthOfLastWord("     Hello World     "));
            Assert.AreEqual(5, sut.LengthOfLastWord("Hello   World "));
            Assert.AreEqual(7, sut.LengthOfLastWord(" Hello World   Goodbye"));
            Assert.AreEqual(2, sut.LengthOfLastWord("Hello World  no     "));
            Assert.AreEqual(0, sut.LengthOfLastWord("     "));
            Assert.AreEqual(0, sut.LengthOfLastWord(""));
            Assert.AreEqual(11, sut.LengthOfLastWord("  onewordonly  "));

            Assert.AreEqual(3, sut.LengthOfLastWord_Naive2("car"));
            Assert.AreEqual(5, sut.LengthOfLastWord_Naive2("Hello World"));
            Assert.AreEqual(5, sut.LengthOfLastWord_Naive2("Hell World "));
            Assert.AreEqual(5, sut.LengthOfLastWord_Naive2(" Hello World"));
            Assert.AreEqual(5, sut.LengthOfLastWord_Naive2("ello World  "));
            Assert.AreEqual(5, sut.LengthOfLastWord_Naive2("     Hello World     "));
            Assert.AreEqual(5, sut.LengthOfLastWord_Naive2("Hello   World "));
            Assert.AreEqual(7, sut.LengthOfLastWord_Naive2(" Hello World   Goodbye"));
            Assert.AreEqual(2, sut.LengthOfLastWord_Naive2("Hello World  no     "));
            Assert.AreEqual(0, sut.LengthOfLastWord_Naive2("     "));
            Assert.AreEqual(0, sut.LengthOfLastWord_Naive2(""));
            Assert.AreEqual(11, sut.LengthOfLastWord_Naive2("  onewordonly  "));
        }
    }
}
