public class Solution {
    public int CharacterReplacement(string s, int k) {
        int low = 0;
        int high = 0;
        int maxFreq = 0;
        int result = 0;
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
            int length = high-low+1;
            result = Math.Max(result,length);
            high++;
            
        }return result;
    }
}
