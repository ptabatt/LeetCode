using LeetCode;
using NUnit.Framework;

namespace LeetCodeUnitTest
{
    [TestFixture]
    public class BestTImeToSellStockTest
    {
        [Test]
        public void BestTimeToSellStockBasicTest_Naive()
        {
            var objSut = new BestTimeToSellStockProblem();

            Assert.AreEqual(5, objSut.MaxProfit_Naive(new[] { 7, 1, 5, 3, 6, 4 }));
            Assert.AreEqual(0, objSut.MaxProfit_Naive(new[] { 7, 6, 4, 3, 1 }));
        }

        [Test]
        public void BestTimeToSellStockEdgeCase1_Naive()
        {
            var objSut = new BestTimeToSellStockProblem();

            Assert.AreEqual(1, objSut.MaxProfit_Naive(new[] { 1, 2 }));
        }

        [Test]
        public void BestTimeToSellStockBasicTest()
        {
            var objSut = new BestTimeToSellStockProblem();

            Assert.AreEqual(5, objSut.MaxProfit(new[] { 7, 1, 5, 3, 6, 4 }));
            Assert.AreEqual(0, objSut.MaxProfit(new[] { 7, 6, 4, 3, 1 }));
        }

        [Test]
        public void BestTimeToSellStockEdgeCase1()
        {
            var objSut = new BestTimeToSellStockProblem();

            Assert.AreEqual(1, objSut.MaxProfit(new[] { 1, 2 }));
        }
    }
}
