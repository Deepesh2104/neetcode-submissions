public class Solution {
    public int MaxSubArray(int[] nums) {
        int best = nums[0];
        int ans = nums[0];

        for(int i = 1; i<nums.Length; i++){
            int contri = nums[i] + best;
            int indi = nums[i];
            best = Math.Max(contri,indi);
            ans = Math.Max(ans,best);
        }
        return ans;
    }
}
