public class Solution {
    public int MaxArea(int[] heights) {
        int max = int.MinValue;
        int left = 0;
        int right = heights.Length-1;
        while(left<right){
            int height = Math.Min(heights[left],heights[right]);
            int width = right-left;
            int container = height*width;
            max = Math.Max(container,max);
            if(heights[left]<heights[right]){
                left++;
            }else{
                right--;
            }
        }
        return max;
    }
}
