public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
            if(nums.Length ==1){
                return new int []  {nums[0]};
            }
            
            Dictionary<int,int>freq = new Dictionary<int,int>();
            List<KeyValuePair<int,int>>list = new List<KeyValuePair<int,int>>();
            List<int>result = new List<int>();
            foreach(var n in nums){
                if(freq.ContainsKey(n)){
                    freq[n]++;
                }else{
                    freq[n] = 1;
                }
            }
            // Add freq in List KeyValuePair
            foreach(var n in freq){
                list.Add(n);
            }
            for(int i = 0; i<list.Count; i++){
                for(int j  = i+1; j<list.Count; j++){
                    if(list[i].Value<list[j].Value){
                        KeyValuePair<int,int>temp = list[i];
                        list[i] = list[j];
                        list[j] = temp;
                    }
                }
            }
            for(int i = 0; i<k; i++){
                result.Add(list[i].Key);
            }
            
            int [] arr = result.ToArray();
            return arr;
    }
}
