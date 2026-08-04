public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        List<List<int>>triplet = new List<List<int>>();
        Array.Sort(nums);
        for(int i = 0;  i<nums.Length-2; i++){
            int start = i+1;
            int end = nums.Length-1;

            if(i>0 && nums[i]==nums[i-1]) continue;

            while(start<end){
                int sum = nums[i]+nums[start]+nums[end];
                if(sum == 0){
                    triplet.Add(new List<int>{nums[i],nums[start],nums[end]});
                    start++;
                    end--;
                    while(start<end && nums[start]==nums[start-1]) start++;
                    while(start<end && nums[end]==nums[end+1]) end--;
                }else if (sum>0){
                    end--;
                }else{
                    start++;
                }
            }
        }
        return triplet;
    }
}
