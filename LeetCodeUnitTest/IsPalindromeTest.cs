using NUnit.Framework;
using LeetCode;

namespace LeetCodeUnitTest
{
    [TestFixture]
    public class IsPalindromeTest
    {
        [Test]
        public void IsPalindrome_BasicTest()
        {
            var sut = new PalindromeNumberProblem();

            var objResult = sut.IsPalindrome(121);

            Assert.IsTrue(objResult);
            
            objResult = sut.IsPalindrome(4004);

            Assert.IsTrue(objResult);

            objResult = sut.IsPalindrome(0);

            Assert.IsTrue(objResult);

            objResult = sut.IsPalindrome(2345);

            Assert.IsFalse(objResult);

            objResult = sut.IsPalindrome(-121);

            Assert.IsFalse(objResult);
        }
    }
}
