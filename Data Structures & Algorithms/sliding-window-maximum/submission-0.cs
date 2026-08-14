public class Solution {

    public int MaxValueNumber(Dictionary<int,int>nums){
        int max = int.MinValue;
        foreach(var num in nums ){
            max = Math.Max(num.Key,max);
        }
        return max;
    }

    public int[] MaxSlidingWindow(int[] nums, int k) {
        int low = 0;
        int high = 0;
        Dictionary<int,int>freq = new Dictionary<int,int>();
        List<int>res = new List<int>();

        while(high<nums.Length){
            int max = int.MinValue;
            if(freq.ContainsKey(nums[high])){
                freq[nums[high]]++;
            }else{
                freq[nums[high]]=1;
            }
            if(high-low+1>k){
                freq[nums[low]]--;
                if(freq[nums[low]]==0){
                    freq.Remove(nums[low]);
                }
                low++;
            }
            if(high-low+1==k){
                res.Add(MaxValueNumber(freq));
            }
            high++;
        }
        return res.ToArray();
    }
}
