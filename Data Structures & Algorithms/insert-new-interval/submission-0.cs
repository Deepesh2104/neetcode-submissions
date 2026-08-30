public class Solution {
    public int[][] Insert(int[][] arr, int[] newInterval) {
        
        int [][] nums = new int [arr.Length+1][];
        List<List<int>>res = new List<List<int>>();
        
        if(arr==null || arr.Length==0){
            return new int [][]{newInterval};
        }
        for(int i = 0; i<arr.Length;i++){
            nums[i] = arr[i];
        }
        nums[arr.Length] = newInterval;
        Array.Sort(nums,(a,b)=>a[0].CompareTo(b[0]));
        int start1 = nums[0][0];
        int end1 = nums[0][1];
        for(int i = 1; i<nums.Length; i++){
            int start2 = nums[i][0];
            int end2 = nums[i][1];
            if(end1>=start2){
                end1 = Math.Max(end1,end2);
            }else{
                res.Add(new List<int>{start1,end1});
                start1 = start2;
                end1 = end2;
                
            }
        }
        res.Add(new List<int>{start1,end1});
        int [][]arr1 = new int[res.Count][];
        for(int i = 0; i<res.Count; i++){
            arr1[i] = res[i].ToArray();
        }
        return arr1;
    }
}
