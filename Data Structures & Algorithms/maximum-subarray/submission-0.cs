public class Solution {
    public int MaxSubArray(int[] nums) {
        int bestEnding = nums[0];
        int ans = nums[0];
        for(int i = 1; i < nums.Length; i++ ){
            int uptoIndex = bestEnding + nums[i];
            int individual = nums[i];
            bestEnding = Math.Max(uptoIndex,individual);
            ans = Math.Max(bestEnding,ans);
        }
        return ans;
    }
}
