using LeetCode;
using NUnit.Framework;

namespace LeetCodeUnitTest
{
    [TestFixture]
    public class SummaryRangeTest
    {
        [Test]
        public void SummaryRangeTest_Example1()
        {
            var sut = new SummaryRangeProblem();

            var input = new[] { 0, 1, 2, 4, 5, 7 };

            var actual = sut.SummaryRanges(input);

            Assert.That(actual.Count == 3, $"Expected Count of 3. Got Count {actual.Count}");
            Assert.That(actual.Contains("0->2"), "0->2 is missing from the list");
            Assert.That(actual.Contains("4->5"), "4->5 is missing from the list");
            Assert.That(actual.Contains("7"), "7 is missing from the list");
        }

        [Test]
        public void SummaryRangeTest_Example2()
        {
            var sut = new SummaryRangeProblem();

            var input = new[] { 0, 2, 3, 4, 6, 8, 9 };

            var actual = sut.SummaryRanges(input);

            Assert.That(actual.Count == 4, $"Expected Count of 4. Got Count {actual.Count}");
            Assert.That(actual.Contains("0"), "0 is missing from the list");
            Assert.That(actual.Contains("2->4"), "2->4 is missing from the list");
            Assert.That(actual.Contains("6"), "6 is missing from the list");
            Assert.That(actual.Contains("8->9"), "8->9 is missing from the list");
        }

        [Test]
        public void SummaryRangeTest_Empty()
        {
            var sut = new SummaryRangeProblem();

            var input = new int[] { };

            var actual = sut.SummaryRanges(input);

            Assert.That(actual.Count == 0, $"Expected Count of 0. Got Count {actual.Count}");
        }

        [Test]
        public void SummaryRangeTest_SingleElement()
        {
            var sut = new SummaryRangeProblem();

            var input = new int[] { 100 };

            var actual = sut.SummaryRanges(input);

            Assert.That(actual.Count == 1, $"Expected Count of 0. Got Count {actual.Count}");

            Assert.That(actual.Contains("100"), "100 is missing from the list");
        }
    }
}
