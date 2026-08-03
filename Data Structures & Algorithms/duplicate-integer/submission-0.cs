public class Solution {
    public bool hasDuplicate(int[] nums) {
        Dictionary<int,int>dict = new Dictionary<int,int>();
        bool isDuplicate = false;
        for(int i = 0; i <nums.Length; i++){
            if(dict.ContainsKey(nums[i])){
                dict[nums[i]]++;
                isDuplicate = true;
                return isDuplicate;
            }else{
                dict[nums[i]] = 1;
            }
        }
        return isDuplicate;
    }
}