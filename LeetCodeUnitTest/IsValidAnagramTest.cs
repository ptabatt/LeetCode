using NUnit.Framework;
using LeetCode;

namespace LeetCodeUnitTest
{
    [TestFixture]
    public class IsValidAnagramTest
    {
        [TestCase("anagram", "nagaram", true)]
        [TestCase("rat", "car", false)]
        [TestCase("doctorgreghouse", "hectordoesgorug", true)]
        [TestCase("astronomer", "moonstarer", true)]
        [TestCase("astronomerxxx", "moonstarerxxxyyy", false)]
        [TestCase("yyyastronomerxxx", "moonstarerxxx", false)]
        public void IsValidAnagramTests(string s, string t, bool expected)
        {
            var sut = new IsAnagramProblem();

            Assert.AreEqual(expected, sut.IsAnagram(s, t));
        }
    }
}
