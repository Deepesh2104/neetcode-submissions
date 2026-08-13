public class Solution {
    public int CharacterReplacement(string s, int k) {
        int low = 0;
        int high = 0;
        int res = 0;
        int maxFreq = 0;
        Dictionary<char,int>freq = new Dictionary<char,int>();
        while(high<s.Length){
            if(freq.ContainsKey(s[high])){
                freq[s[high]]++;
            }else{
                freq[s[high]] = 1;
            }
            maxFreq = Math.Max(maxFreq,freq[s[high]]);
            while((high-low+1)-maxFreq>k){
                freq[s[low]]--;
                if(freq[s[low]]==0){
                    freq.Remove(s[low]);
                }
                low++;
            }
            int l = high-low+1;
            res = Math.Max(res,l);
            high++;
        }
        return res;
    }
}
