using LeetCode;
using NUnit.Framework;

namespace LeetCodeUnitTest
{
    [TestFixture]
    public class IsIsomorphicTest
    {
        [TestCase("egg","add", true)]
        [TestCase("foo", "bar", false)]
        [TestCase("paper", "title", true)]
        [TestCase("badc", "baba", false)]
        public void IsIsomorphicBasicTest(string givenS, string givenT, bool expected) 
        {
            var sut = new IsIsomorphicProblem();
            Assert.That(sut.IsIsomorphic(givenS, givenT), Is.EqualTo(expected));
        }
    }
}
