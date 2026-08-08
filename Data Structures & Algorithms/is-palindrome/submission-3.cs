public class Solution {
    public bool IsPalindrome(string s) {
        
        string temp = "";
        
        foreach(char str in s){
            if(char.IsLetterOrDigit(str)){
               
                temp+=char.ToLower(str);
            }
        }
        int left = 0;
        int right = temp.Length-1;
        Console.WriteLine(temp);
        while(left<right){
            
            if(temp[left]!=temp[right]){
                return false;
            }
            Console.WriteLine($"left {temp[left]} right {temp[right]}");
            left++;
            right--;
        }
        return true;
    }
}
