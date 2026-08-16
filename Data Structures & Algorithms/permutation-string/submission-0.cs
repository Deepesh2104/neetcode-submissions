public class Solution {
    public bool permutations(Dictionary<char,int>s1Freq,Dictionary<char,int>s2Freq){
        foreach(var item in s1Freq){
            if(!s2Freq.ContainsKey(item.Key))return false;
            if(s2Freq[item.Key]!=item.Value) return false;
        }
        return true;
    }
    public bool CheckInclusion(string s1, string s2) {
        int low  = 0;
        int high = 0;
        Dictionary<char,int>s1Freq = new Dictionary<char,int>();
        Dictionary<char,int>s2Freq = new Dictionary<char,int>();

        foreach(char c in  s1 ){
            if(s1Freq.ContainsKey(c)){
                s1Freq[c]++;
            }else{
                s1Freq[c]=1;
            }
        }
        while(high<s2.Length){
            if(s2Freq.ContainsKey(s2[high])){
                s2Freq[s2[high]]++;
            }else{
                s2Freq[s2[high]]=1;
            }
            if(high-low+1>s1.Length){
                s2Freq[s2[low]]--;
                if(s2Freq[s2[low]]==0){
                    s2Freq.Remove(s2[low]);
                }
                low++;
            }
            if(high-low+1==s1.Length){
                if(permutations(s1Freq,s2Freq)){
                    return true;
                }
            }
            high++;
        }
        return false;
    }
}
