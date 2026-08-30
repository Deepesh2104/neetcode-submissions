public class Solution {
    public int[][] Merge(int[][] arr) {
        List<List<int>>result = new List<List<int>>();
        
        if(arr==null || arr.Length==0){
            return new int[0][];
        }
        Array.Sort(arr,(a,b)=>a[0].CompareTo(b[0]));
        int start1 = arr[0][0];
        int end1 = arr[0][1];
        
        for(int i = 1; i<arr.Length; i++){
            int start2 = arr[i][0];
            int end2 = arr[i][1];
            if(end1>=start2){
                end1 = Math.Max(end1,end2);
            }else{
            result.Add(new List<int>{start1,end1});
            start1 = start2;
            end1 = end2;
            }
        }
        result.Add(new List<int>{start1,end1});
        int [][]nums = new int [result.Count][];
        for(int i = 0; i<result.Count; i++){
            nums[i] = result[i].ToArray();
        }
        return nums;
    }
}
