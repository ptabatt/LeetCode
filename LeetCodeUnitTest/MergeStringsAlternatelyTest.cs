using LeetCode;
using NUnit.Framework;

namespace LeetCodeUnitTest
{
    [TestFixture]
    public class MergeStringsAlternatelyTest
    {
        [TestCase("abc", "pqr", "apbqcr")]
        [TestCase("ab", "pqrs", "apbqrs")]
        [TestCase("abcd", "pq", "apbqcd")]
        public void MergeStringsLeetCodeCases(string word1, string word2, string expected)
        {
            var sut = new MergeStringsAlternatelyProblem();
            Assert.That(sut.MergeAlternately(word1, word2), Is.EqualTo(expected));
        }
    }
}
