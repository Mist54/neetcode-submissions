public class Solution {
    public int MaxProfit(int[] prices) {
        int left = 0;
        int right = 1;
        int maxPrice = 0;
        for (int i = 0; i < prices.Length - 1; i++) {
            if (prices[right] > prices[left]) {
                int currentPrice = prices[right] - prices[left];
                maxPrice = Math.Max(currentPrice, maxPrice);
            } 
            else {
                left = right; 
            }
            right++;
        }
        return maxPrice;
    }
}
