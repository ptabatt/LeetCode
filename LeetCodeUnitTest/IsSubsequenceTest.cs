using LeetCode;
using NUnit.Framework;

namespace LeetCodeUnitTest
{
    [TestFixture]
    public class IsSubsequenceTest
    {
        [TestCase("abc", "ahbgdc", true)]
        [TestCase("axc", "ahbgdc", false)]
        [TestCase("", "ahbgdc", true)]
        [TestCase("", "", true)]
        [TestCase("b", "c", false)]
        public void IsSubsequenceLeetCodeExamples(string s, string t, bool expected)
        {
            var sut = new IsSubsequenceProblem();
            Assert.AreEqual(expected, sut.IsSubsequence(s, t));
        }
    }
}
