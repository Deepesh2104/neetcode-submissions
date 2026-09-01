/**
 * Definition of Interval:
 * public class Interval {
 *     public int start, end;
 *     public Interval(int start, int end) {
 *         this.start = start;
 *         this.end = end;
 *     }
 * }
 */

public class Solution {
    public bool CanAttendMeetings(List<Interval> intervals) {
        if(intervals.Count==0){
            return true;
        }
        intervals.Sort((a,b) => a.start.CompareTo(b.start));
        int start1=intervals[0].start;
        int end1 =intervals[0].end;
        
        for(int i = 1; i<intervals.Count; i++){
            int start2= intervals[i].start;
            int end2 = intervals[i].end;
            if(end1>start2){
                return false;
            }else{
                start1 = start2;
                end1 = end2;
            }
        }
       
        return true;
    }
}
