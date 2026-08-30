public class Solution {
    public int EraseOverlapIntervals(int[][] intervals) {
        if(intervals==null || intervals.Length==0){
            return 0;
        }
        int count = 0;
        Array.Sort(intervals,(a,b)=>a[0].CompareTo(b[0]));
        int start1 = intervals[0][0];
        int end1 = intervals[0][1];
        for(int i = 1; i<intervals.Length; i++){
            int start2 = intervals[i][0];
            int end2 = intervals[i][1];
            if(end1>start2){
                count+=1;
                end1 = Math.Min(end1,end2);
                
            }else{
                start1 = start2;
                end1 = end2;
            }
            
        }
        return count;
    }
}
