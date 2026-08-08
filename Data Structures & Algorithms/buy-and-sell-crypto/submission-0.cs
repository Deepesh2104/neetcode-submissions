public class Solution {
    public int MaxProfit(int[] prices) {
        int minPrice = int.MaxValue;
        int maxProfit = 0;

        foreach(var p in prices){
            minPrice = Math.Min(p,minPrice);
            int profit = p-minPrice;
            maxProfit = Math.Max(profit,maxProfit);

        }
        return maxProfit;
    }
}
