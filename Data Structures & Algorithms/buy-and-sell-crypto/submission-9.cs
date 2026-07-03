public class Solution {
    public int MaxProfit(int[] prices) {
        int minPrice = prices[0];
        int profit = 0;

        for (int i = 1 ; i < prices.Length ; i++){
            if (prices[i] < minPrice){
                minPrice = prices[i];
            } else {
                profit = Math.Max(profit, prices[i] - minPrice);
            }
        }

        return profit;
    }
}
