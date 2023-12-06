using LeetCode;
using NUnit.Framework;

namespace LeetCodeUnitTest
{
    [TestFixture]
    public class JumpGameTest
    {
        [TestCase(new[] { 2, 3, 1, 1, 4 }, true)]
        [TestCase(new[] { 3, 2, 1, 0, 4 }, false)]
        [TestCase(new[] { 1, 1, 1, 1, 4 }, true)]
        [TestCase(new[] { 8, 0, 0, 0, 0, 0, 0, 0, 0 }, true )]
        [TestCase(new[] { 8, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, false)]
        [TestCase(new[] { 0 }, true)]
        [TestCase(new[] { 10, 11 }, true)]
        [TestCase(new[] { 5, 1, 1, 2, 3, 4, 0, 0, 0, 11 }, true)]
        [TestCase(new[] { 0, 1 }, false)]
        [TestCase(new[] { 4, 2, 0, 0, 1, 1, 4, 4, 4, 0, 4, 0 }, true)]
        public void JumpGameTestCases(int[] given, bool expected)
        {
            var sut = new JumpGameProblem();
            Assert.That(sut.CanJump(given), Is.EqualTo(expected));
        }

        [Test]
        public void JumpGameStressTest()
        {
            var arr = new int[1000];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = 100000;
            }

            var sut = new JumpGameProblem();
            Assert.That(sut.CanJump(arr), Is.True);
        }
    }
}
