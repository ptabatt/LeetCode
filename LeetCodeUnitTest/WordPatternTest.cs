using LeetCode;
using NUnit.Framework;

namespace LeetCodeUnitTest
{
    [TestFixture]
    public class WordPatternTest
    {
        [TestCase("abba", "dog cat cat dog", true)]
        [TestCase("abba", "dog cat cat fish", false)]
        [TestCase("aaaa", "dog cat cat dog", false)]
        [TestCase("a", "word test", false)]
        [TestCase("zzz", "one", false)]
        [TestCase("abcdefg", "one two three four five six seven", true)]
        public void WordPatternLeetCodeExamples(string pattern, string s, bool expected)
        {
            var objSut = new WordPatternProblem();

            Assert.That(objSut.WordPattern(pattern, s), Is.EqualTo(expected));
        }
    }
}
