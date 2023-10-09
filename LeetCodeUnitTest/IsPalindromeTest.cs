using LeetCode;
using NUnit.Framework;

namespace LeetCodeUnitTest
{
    [TestFixture]
    public class IsPalindromeTest
    {
        [TestCase("A man, a plan, a canal: Panama", true)]
        [TestCase("race a car", false)]
        [TestCase("racecar", true)]
        [TestCase("ABBA", true)]
        [TestCase("ABBA Gold", false)]
        [TestCase("9i9", true)]
        [TestCase("9i9e", false)]
        [TestCase("   ", true)]
        public void IsPalindromeBasicTests(string s, bool isPalindrome)
        {
            var sut = new IsPalindromeProblem();

            Assert.AreEqual(isPalindrome, sut.IsPalindrome(s));
        }
    }
}
