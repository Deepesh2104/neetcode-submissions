public class Solution {
    
    public bool CheckInclusion(string s1, string s2) {
        int low  = 0;
        int high = 0;
        int match = 0;
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

            if(s1Freq.ContainsKey(s2[high]) && s1Freq[s2[high]]==s2Freq[s2[high]])
            {
                match++;
            }    
                
            if(high-low+1>s1.Length){
                if(s1Freq.ContainsKey(s2[low]) && s1Freq[s2[low]]==s2Freq[s2[low]])
                {
                    match--;
                }
                s2Freq[s2[low]]--;
                if(s2Freq[s2[low]]==0){
                    s2Freq.Remove(s2[low]);
                }
                low++;
            }
        if(match==s1Freq.Count){
            return true;
        }
            high++;
        }
        return false;
        
    }
}
