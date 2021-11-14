using LeetCode;
using NUnit.Framework;

namespace LeetCodeUnitTest
{
    [TestFixture]
    public class ContainerWithMostWaterTest
    {
        [Test]
        public void ContainerWIthMostWater_GreedyImplTest()
        {
            var sut = new ContainerWithMostWaterProblem();

            Assert.AreEqual(49, sut.MaxArea(new[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 }));
            Assert.AreEqual(1, sut.MaxArea(new[] { 1, 1 }));
            Assert.AreEqual(16, sut.MaxArea(new[] { 4, 3, 2, 1, 4 }));
            Assert.AreEqual(2, sut.MaxArea(new[] { 1, 2, 1 }));
        }

        [Test]
        public void ContainerWIthMostWater_NaiveImplTest()
        {
            var sut = new ContainerWithMostWaterProblem();

            Assert.AreEqual(49, sut.MaxAreaNaive(new[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 }));
            Assert.AreEqual(1, sut.MaxAreaNaive(new[] { 1, 1 }));
            Assert.AreEqual(16, sut.MaxAreaNaive(new[] { 4, 3, 2, 1, 4 }));
            Assert.AreEqual(2, sut.MaxAreaNaive(new[] { 1, 2, 1 }));
        }
    }
}
