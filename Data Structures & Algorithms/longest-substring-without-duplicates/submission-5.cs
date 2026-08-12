public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int low = 0;
        int high = 0;
        int result = 0;
        if (string.IsNullOrEmpty(s))
    return 0;

if (string.IsNullOrWhiteSpace(s))
    return 1;
        Dictionary<char,int>freq = new Dictionary<Char,int>();
        while(high<s.Length){
            if(freq.ContainsKey(s[high])){
                freq[s[high]] ++;
            }else{
                freq[s[high]] = 1;
            }

            while(freq[s[high]]>1){
                freq[s[low]]--;
                if(freq[s[low]]==0){
                    freq.Remove(s[low]);
                }
                low++;
            }
            int length  = high-low+1;
            result = Math.Max(length,result);
            high++;
        }
        return result;
    }
}
