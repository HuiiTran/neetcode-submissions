public class Solution {
    public int MaxProfit(int[] prices) {
        int max = 0;
        for(int i = 0; i < prices.Length; i++){
            for(int j = i; j < prices.Length; j++){
                int currProfit = prices[j] - prices[i];
                max = Math.Max(max, currProfit);
            }
        }
        return max;
    }
}
