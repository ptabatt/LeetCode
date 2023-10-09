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
        public int MaxProfit_Naive(int[] prices)
        {
            var iMaxProfit = 0;

            for (int i = 0; i < prices.Length; i++)
            {
                var iLocalMaxProfit = 0;

                for (int j = i + 1; j < prices.Length; j++)
                {
                    var iDelta = prices[j] - prices[i];

                    if (iDelta > iLocalMaxProfit)
                    {
                        iLocalMaxProfit = iDelta;
                    }
                }

                if (iLocalMaxProfit > iMaxProfit)
                {
                    iMaxProfit = iLocalMaxProfit;
                }
            }

            return iMaxProfit;
        }

        // One-pass solution that works in O(n) time and has O(1) memory
        public int MaxProfit(int[] prices)
        {
            var maxProfit = 0;
            var idxLowestMinDay = 0;

            for (int i = 1; i < prices.Length; i++)
            {
                var currentProfit = prices[i] - prices[idxLowestMinDay];
                if (currentProfit > maxProfit)
                {
                    maxProfit = currentProfit;
                }
                else if (prices[i] < prices[idxLowestMinDay])
                {
                    idxLowestMinDay = i;
                }
            }

            return maxProfit;
        }
    }
}