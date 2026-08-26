public class Solution {
    public int MaxProduct(int[] nums) {
        int currentMax = nums[0];
        int currentMin = nums[0];
        int res = nums[0];
        for(int i = 1; i<nums.Length; i++){
            int previousMax = nums[i] * currentMax;
            int previousMin = nums[i] * currentMin;

            currentMax = Math.Max(previousMax,Math.Max(previousMin,nums[i]));
            currentMin = Math.Min(previousMin,Math.Min(previousMax,nums[i]));
            res =Math.Max(res,Math.Max(currentMax,currentMin));
        }
        return res;
    }
}
