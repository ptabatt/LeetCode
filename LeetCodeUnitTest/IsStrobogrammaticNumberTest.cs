using LeetCode;
using NUnit.Framework;

namespace LeetCodeUnitTest
{
    [TestFixture]
    public class IsStrobogrammaticNumberTest
    {
        [TestCase("69", true)]
        [TestCase("88", true)]
        [TestCase("808", true)]
        [TestCase("962", false)]
        [TestCase("8888885", false)]
        public void IsStrobogrammaticTestCases(string num, bool expected)
        {
            var sut = new IsStrobogrammaticProblem();
            Assert.That(sut.IsStrobogrammatic(num), Is.EqualTo(expected));
        }
    }
}
