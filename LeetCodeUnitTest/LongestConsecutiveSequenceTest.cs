using LeetCode;
using NUnit.Framework;

namespace LeetCodeUnitTest
{
    [TestFixture]
    public class LongestConsecutiveSequenceTest
    {
        [Test]
        public void LongestConsecutiveSequenceBasicTest1()
        {
            var objSut = new LongestConsecutiveSequenceProblem();
            Assert.AreEqual(4, objSut.LongestConsecutive(new[] { 100, 4, 200, 1, 3, 2 }));
        }

        [Test]
        public void LongestConsecutiveSequenceBasicTest2()
        {
            var objSut = new LongestConsecutiveSequenceProblem();
            Assert.AreEqual(9, objSut.LongestConsecutive(new[] { 0, 3, 7, 2, 5, 8, 4, 6, 0, 1 }));
        }

        [Test]
        public void LongestConsecutiveSequenceEmptyTest()
        {
            var objSut = new LongestConsecutiveSequenceProblem();
            Assert.AreEqual(0, objSut.LongestConsecutive(new int[] { }));
        }

        [Test]
        public void LongestConsecutiveSequenceEdgeCaseTest()
        {
            var objSut = new LongestConsecutiveSequenceProblem();
            Assert.AreEqual(3, objSut.LongestConsecutive(new int[] { 1, 2, 0, 1 }));
        }
    }
}
