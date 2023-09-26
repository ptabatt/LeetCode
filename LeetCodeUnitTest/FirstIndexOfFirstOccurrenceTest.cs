using LeetCode;
using NUnit.Framework;

namespace LeetCodeUnitTest
{
    [TestFixture]
    public class FirstIndexOfFirstOccurrenceTest
    {
        [TestCase("sadbutsad", "sad", 0)]
        [TestCase("leetcode", "leeto", -1)]
        [TestCase("a", "a", 0)]
        [TestCase("aaa", "aaaa", -1)]
        [TestCase("aaaba", "bab", -1)]
        public void FirstIndexOfFirstOccurence_BasicTest(string haystack, string needle, int expected)
        {
            var sut = new FirstIndexOfFirstOccurrenceProblem();

            Assert.AreEqual(expected, sut.StrStr(haystack, needle));
        }
    }
}
