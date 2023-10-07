using NUnit.Framework;
using System.Linq;
using LeetCode;

namespace LeetCodeUnitTest
{
    [TestFixture]
    public class RemoveElementTest
    {
        [Test]
        public void RemoveElement_BasicTest()
        {
            var nums = new[] { 0, 1, 2, 2, 3, 0, 4, 2 };
            var val = 2;

            var objSut = new RemoveElementProblem();
            var result = objSut.RemoveElement(nums, val);

            var numSlice = nums.Skip(0).Take(result);

            Assert.AreEqual(5, result);
            Assert.That(numSlice, Has.Exactly(2).EqualTo(0));
            Assert.That(numSlice, Has.Exactly(1).EqualTo(1));
            Assert.That(numSlice, Has.Exactly(1).EqualTo(4));
            Assert.That(numSlice, Has.Exactly(1).EqualTo(3));
        }
    }
}
