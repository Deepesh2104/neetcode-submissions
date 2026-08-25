public class Solution {
    public int MaxProduct(int[] nums) {
        int currentMax = nums[0];
        int currentMin = nums[0];
        int ans = nums[0];
        int temp = 0;
        for(int i  = 1; i<nums.Length; i++){
            currentMax = currentMax*nums[i];
            currentMin = currentMin*nums[i];
            int k = nums[i];
            int max = Math.Max(currentMax,Math.Max(currentMin,k));
            int min = Math.Min(currentMin,Math.Min(currentMax,k));
            
            temp = Math.Max(max,min);

            ans = Math.Max(temp,ans);
            currentMax = max;
            currentMin = min;
        }
        return ans;
    }
}
