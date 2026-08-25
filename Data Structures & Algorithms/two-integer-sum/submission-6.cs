public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int left = 0;
        Dictionary<int,int>freq = new Dictionary<int,int>();
        while(left<nums.Length){
            int complement = target - nums[left];
            if(freq.ContainsKey(complement)){
                return new int [] {freq[complement],left};
            }
            else{
                freq[nums[left]]=left;
            }
            left++;
        }
        return new int[]{0};
    }
}
