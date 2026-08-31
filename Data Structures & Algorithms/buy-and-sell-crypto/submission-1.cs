public class Solution {
    public int MaxProfit(int[] prices) {
        int minPrice = int.MaxValue;
        int ans = 0;
        foreach(var price in prices){
            minPrice = Math.Min(minPrice,price);
            int profit = price-minPrice;
            ans = Math.Max(ans,profit);
        }
        return ans;
    }
}
