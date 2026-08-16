public class Solution {
    public string MinWindow(string s, string t) {
        int low = 0;
        int high = 0;
        int startIndex = -1;
        int endIndex =-1;
        string res = "";
        int match = 0;
        int minValue = int.MaxValue;
        Dictionary<char,int>sFreq = new Dictionary<char,int>();
        Dictionary<char,int>tFreq = new Dictionary<char,int>();
        
        foreach(char c in t){
            if (tFreq.ContainsKey(c))
                tFreq[c]++;
            else
                tFreq[c] = 1;
        }
        while(high<s.Length){
            if(sFreq.ContainsKey(s[high])){
                sFreq[s[high]]++;
            }else{
                sFreq[s[high]]=1;
            }

            if(tFreq.ContainsKey(s[high]) && sFreq[s[high]]==tFreq[s[high]] ){
                match++;
            }
            while(match == tFreq.Count){
                int currentLength = high-low+1;
                if(currentLength<minValue){
                    minValue = currentLength;
                    startIndex = low;
                    endIndex = high;
                }
                if(tFreq.ContainsKey(s[low]) && sFreq[s[low]]==tFreq[s[low]]){
                    match--;
                }
                sFreq[s[low]]--;
                if(sFreq[s[low]]==0){
                    sFreq.Remove(s[low]);
                }
                low++;
            }
            high++;
        }
        if(startIndex == -1){
            return"";
        }
        for(int i = startIndex; i<=endIndex; i++){
            res+=s[i];
        }
        return res;

    }
}
