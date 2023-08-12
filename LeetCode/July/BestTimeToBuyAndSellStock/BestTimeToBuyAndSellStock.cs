namespace LeetCode;

public class BestTimeToBuyAndSellStock {
    public int MaxProfit(int[] prices)
    {
        // Initialize variables to track the minimum price and maximum profit
        var minPrice = int.MaxValue;
        var maxProfit = 0;

        // Iterate through the array of prices
        for (var i = 0; i < prices.Length; i++)
        {
            // Check if the current price is lower than the minimum price found so far
            if (prices[i] < minPrice)
            {
                // Update the minimum price
                minPrice = prices[i];
            }
            else if (prices[i] - minPrice > maxProfit)
            {
                // Calculate the potential profit from selling at the current price
                // Update the maximum profit if the potential profit is greater
                maxProfit = prices[i] - minPrice;
            }
        }

        return maxProfit;
    }
}