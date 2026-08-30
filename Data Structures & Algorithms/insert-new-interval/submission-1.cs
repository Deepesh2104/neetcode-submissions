public class Solution {
    public int[][] Insert(int[][] intervals, int[] newInterval) {
        List<List<int>>updateInterval = new List<List<int>>();
        List<List<int>>res = new List<List<int>>();
        if(intervals==null || intervals.Length==0){
            return new int[][]{newInterval};
        }
        
        bool isInsert = false;
        for(int i = 0; i <intervals.Length; i++){
            int start = intervals[i][0];
            if(isInsert==false && start>=newInterval[0]){
                updateInterval.Add(new List<int>{newInterval[0], newInterval[1]});
                isInsert = true;
            }
            updateInterval.Add(new List<int>{
                intervals[i][0],
                intervals[i][1]
            });
        }
        if(isInsert == false) updateInterval.Add(new List<int>{newInterval[0], newInterval[1]});

        int start1 = updateInterval[0][0];
        int end1 = updateInterval[0][1];        

        for(int i = 1; i<updateInterval.Count; i++){
            int start2 = updateInterval[i][0];
            int end2 = updateInterval[i][1];
            if(end1>=start2){
                end1 = Math.Max(end1,end2);
            }else{
                res.Add(new List<int>{start1,end1});
                start1 = start2;
                end1 = end2;
            }
        }
        res.Add(new List<int>{start1,end1});
        int [][]r = new int [res.Count][];
        for(int i = 0; i<res.Count; i++){
            r[i] = res[i].ToArray();
        }
        return r;
    }
}
