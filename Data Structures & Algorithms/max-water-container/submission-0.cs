public class Solution {
    public int MaxArea(int[] height) {
        int left = 0;
        int right =  height.Length-1;
        int maxWater = 0;

        while(left<right){
            int h = Math.Min(height[left],height[right]);
            int w = right - left;
            int container = h*w;
            maxWater = Math.Max(container,maxWater);
            if(height[left]<height[right]){left++;}else{right--;}
        }
        return maxWater;
    }
}
