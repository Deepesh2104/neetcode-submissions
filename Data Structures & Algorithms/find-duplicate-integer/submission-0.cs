public class Solution {
    public int FindDuplicate(int[] nums) {
        int res = -1;
        int slow = 0;
        int fast = 0;
        while(true){
            slow = nums[slow];
            fast = nums[nums[fast]];
            if(slow==fast){
                break;
            }
        }
        int pointer = 0;
        while(pointer!=slow){
                pointer = nums[pointer];
                slow = nums[slow];
        }
        return slow;
    }
}
