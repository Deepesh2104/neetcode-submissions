public class Solution {
    public bool IsHappy(int n) {
        HashSet<int>num = new HashSet<int>();
        while(n!=1){
            if(num.Contains(n)){
                return false;
            }
            num.Add(n);
            int sum = 0;

            while(n>0){
                int digit = n%10;
                sum+=digit*digit; 
                n=n/10;
            }
            n=sum;
        }
        return true;
    }
}
