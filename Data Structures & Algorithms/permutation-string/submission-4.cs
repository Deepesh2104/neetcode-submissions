public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        int []s1Freq = new int[26];
        int []windowFreq = new int[26];
        foreach(char c in s1){
            s1Freq[c-'a']++;
        } 
        if(s2.Length<s1.Length)return false;
        for(int i = 0; i<s2.Length; i++){
            windowFreq[s2[i]-'a']++;
            if(i>=s1.Length){
                windowFreq[s2[i-s1.Length]-'a']--;
            }
            if(i>=s1.Length-1 && s1Freq.SequenceEqual(windowFreq)){
                return true;
            }
        }
        return false;
    }
}
