public class Solution {
    public int[] TwoSum(int[] arr, int targett) {
        
        List<int>nums = new List<int>();
        for(int i = 0; i<arr.Length; i++){
            int complement = targett - arr[i];
            if(!nums.Contains(complement)){
                nums.Add(arr[i]);
            }else{
                int index = Array.IndexOf(arr,complement);
                return new int[]{index,i};
            }
        }
        return new int[]{0};
    }
}
