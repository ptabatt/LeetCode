using LeetCode;
using NUnit.Framework;

namespace LeetCodeUnitTest
{
    [TestFixture]
    public class RansomNoteTest
    {
        [TestCase("a", "b", false)]
        [TestCase("aa", "ab", false)]
        [TestCase("aa", "aab", true)]
        public void RansomeNote_BasicTests(string ransomNote, string magazine, bool expected)
        {
            var objSut = new RandomNoteProblem();

            Assert.AreEqual(expected, objSut.CanConstruct(ransomNote, magazine));
        }
    }
}
