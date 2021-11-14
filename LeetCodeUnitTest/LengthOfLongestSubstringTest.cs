using NUnit.Framework;
using System;
using LeetCode;

namespace LeetCodeUnitTest
{
    [TestFixture]
    public class LengthOfLongestSubstringTest
    {
        [Test]
        public void LengthOfLongestSubstring_BasicTest()
        {
            var sut = new LengthOfLongestSubstringProblem();

            Assert.AreEqual(3, sut.LengthOfLongestSubstring("abcabcbb"));
            Assert.AreEqual(1, sut.LengthOfLongestSubstring("bbbbb"));
            Assert.AreEqual(3, sut.LengthOfLongestSubstring("pwwkew"));
            Assert.AreEqual(9, sut.LengthOfLongestSubstring("abcddzyxwvuioio"));
            Assert.AreEqual(0, sut.LengthOfLongestSubstring(""));
            Assert.AreEqual(1, sut.LengthOfLongestSubstring(" "));
        }
    }
}
