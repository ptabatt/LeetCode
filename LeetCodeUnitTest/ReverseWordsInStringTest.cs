using LeetCode;
using NUnit.Framework;

namespace LeetCodeUnitTest
{
    [TestFixture]
    public class ReverseWordsInStringTest
    {
        [TestCase("the sky is blue", "blue is sky the")]
        [TestCase("a good   example", "example good a")]
        [TestCase("  hello world  ", "world hello")]
        public void ReverseWordsInStringTests(string given, string expected)
        {
            var sut = new ReverseWordsInStringProblem();

            Assert.AreEqual(expected, sut.ReverseWords(given));
        }
    }
}
