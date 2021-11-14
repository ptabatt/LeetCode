using System;
using NUnit;
using NUnit.Framework;
using LeetCode;

namespace LeetCodeUnitTest
{
    [TestFixture]
    public class FindDuplicatesTest
    {
        [Test]
        public void FindDuplicates_Test()
        {
            var input = new[] { 4, 3, 2, 7, 8, 2, 3, 1 };

            var sut = new FindAllDuplicatesInArrayProblem();

            var actualOutput = sut.FindDuplicates(input);

            Assert.AreEqual(2, actualOutput.Count);
            Assert.IsTrue(actualOutput.Contains(3));
            Assert.IsTrue(actualOutput.Contains(2));
        }

        [Test]
        public void FindDuplicatesSecondAttempt_Test()
        {
            var input = new[] { 4, 3, 2, 7, 8, 2, 3, 1 };

            var sut = new FindAllDuplicatesInArrayProblemSecondAttempt();

            var actualOutput = sut.FindDuplicates(input);

            Assert.AreEqual(2, actualOutput.Count);
            Assert.IsTrue(actualOutput.Contains(3));
            Assert.IsTrue(actualOutput.Contains(2));
        }
    }
}
