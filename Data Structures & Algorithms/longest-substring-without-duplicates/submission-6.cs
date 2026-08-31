public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int low = 0;
        int high = 0;
        int ans = 0;
        Dictionary<char,int>freq = new Dictionary<char,int>();
        while(high<s.Length){
            if(freq.ContainsKey(s[high])){
                freq[s[high]]++;
            }else{
                freq[s[high]]=1;
            }
            while(freq[s[high]]>1){
                freq[s[low]]--;
                if(freq[s[low]]==0){
                    freq.Remove(s[low]);
                }
                low++;
            }
            int l = high-low+1;
            ans = Math.Max(ans,l);
            high++;
        }
        return ans;
    }
}
