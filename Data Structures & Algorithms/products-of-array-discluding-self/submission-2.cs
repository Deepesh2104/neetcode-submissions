public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int [] arr = new int [nums.Length];
        arr[0] = 1;
        for(int i = 1; i<nums.Length; i++){
            arr[i] = arr[i-1] * nums[i-1];
        }
        int right  = 1;
        for(int j = nums.Length-1; j>=0 ; j--){
            arr[j]*=right;
            right*=nums[j];
        }
        return arr;
    }
}
