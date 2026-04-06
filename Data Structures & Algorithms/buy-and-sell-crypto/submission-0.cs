public class Solution {
    public int MaxProfit(int[] prices)
    {
        if (prices.Length == 0)
            return 0;

        int minPrice = prices[0];
        int maxProfit = 0;

        for (int i = 0; i < prices.Length; i++)
        {
            int currentProfit = prices[i] - minPrice;

            if (currentProfit > maxProfit)
                maxProfit = currentProfit;
            
            if (prices[i] < minPrice)
                minPrice = prices[i];
        }

        return maxProfit;
    }
}
