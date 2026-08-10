public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        
        List<int>arr = new List<int>() ;
        if(nums.Length ==1){
            return new int [] {nums[0]};
        }
        Dictionary<int,int>maxCount = new Dictionary<int,int>();
        List<KeyValuePair<int,int>> list = new List<KeyValuePair<int,int>>();
        for(int i = 0; i<nums.Length; i++){
            if(maxCount.ContainsKey(nums[i])){
                maxCount[nums[i]]++;
            }else{
                maxCount[nums[i]]=1;
            }
        }
        foreach (var item in maxCount)
        {
            list.Add(item);
        }
        for(int i = 0 ; i<list.Count;i++){
            for(int j = i+1; j<list.Count; j++){
                if(list[i].Value<list[j].Value){
                    KeyValuePair<int,int>temp = list[i];
                    list[i] = list[j];
                    list[j] = temp;
                }
            }
        }
        for(int i = 0; i<k; i++){
            arr.Add(list[i].Key);
        }
        return arr.ToArray();
    }
}
