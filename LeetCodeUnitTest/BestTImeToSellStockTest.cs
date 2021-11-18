using LeetCode;
using NUnit.Framework;

namespace LeetCodeUnitTest
{
    [TestFixture]
    public class BestTImeToSellStockTest
    {
        [Test]
        public void BestTimeToSellStockBasicTest()
        {
            var objSut = new BestTimeToSellStockProblem();

            Assert.AreEqual(7, objSut.MaxProfit(new[] { 1, 2, 3, 4, 5, 6, 7 }));
            Assert.AreEqual(7, objSut.MaxProfit(new[] { 1, 2, 3, 4, 5, 6, 7, 3 }));
            Assert.AreEqual(9, objSut.MaxProfit(new[] { 1, 2, 3, 4, 5, 6, 7, 3, 10 }));
            Assert.AreEqual(5, objSut.MaxProfit(new[] { 7, 1, 5, 3, 6, 4 }));
            Assert.AreEqual(0, objSut.MaxProfit(new[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 }));
        }
    }
}
