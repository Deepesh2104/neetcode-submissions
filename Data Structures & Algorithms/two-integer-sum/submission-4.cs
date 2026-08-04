public class Solution {
    public int[] TwoSum(int[] arr, int targett) {
        
        Dictionary<int,int>nums = new Dictionary<int,int>();
        for(int i = 0; i<arr.Length; i++){
            int complement = targett - arr[i];
            if(nums.ContainsKey(complement)){
                return new int[]{nums[complement],i};
            }
            nums[arr[i]] = i;
        }
        return new int[]{0};
    }
}
