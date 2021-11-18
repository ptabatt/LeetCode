namespace LeetCode
{
    public class BestTimeToSellStockProblem
    {
        /// <summary>
        /// You are given an array prices where prices[i] is the price of a 
        /// given stock on the ith day.
        /// You want to maximize your profit by choosing a single day to 
        /// buy one stock and choosing a different day in the future to sell 
        /// that stock.
        /// Return the maximum profit you can achieve from this transaction.
        /// If you cannot achieve any profit, return 0.
        /// </summary>
        /// <param name="prices"></param>
        /// <returns></returns>
        public int MaxProfit(int[] prices)
        {
            var iMaxProfit = 0;
            var iDayOfMaxProfit = 0;

            for (int i = 0; i < prices.Length; i++)
            {
                var iLocalMaxProfit = 0;
                var iLocalDayOfMaxProfit = 0;

                for (int j = i + 1; j < prices.Length; j++)
                {
                    var iDelta = prices[j] - prices[i];

                    if (iDelta > iLocalMaxProfit)
                    {
                        iLocalMaxProfit = iDelta;
                        iLocalDayOfMaxProfit = j + 1;
                    }
                }

                if (iLocalMaxProfit > iMaxProfit)
                {
                    iMaxProfit = iLocalMaxProfit;
                    iDayOfMaxProfit = iLocalDayOfMaxProfit;
                }
            }

            return iDayOfMaxProfit;
        }
    }
}