public class Solution {
    public string MinWindow(string s, string t) {
        // Handle Edge Conditions
        if(s.Length<t.Length){
            return "";
        }

        int low = 0;
        int high = 0;
        string res = "";
        int startIndex = -1;
        int endIndex = -1;
        int match = 0;
        int minLength = int.MaxValue;
        
        Dictionary<char,int>freq = new Dictionary<char,int>();
        Dictionary<char,int>data = new Dictionary<char,int>();

        foreach(char c in t){
            if(data.ContainsKey(c)){
                data[c]++;
            }else{
                data[c]=1;
            }
        }

        while(high<s.Length){
            if(freq.ContainsKey(s[high])){
                freq[s[high]]++;
            }else{
                freq[s[high]] = 1;
            }

            if(data.ContainsKey(s[high]) && freq[s[high]]==data[s[high]]){
                match++;
            }

            while(match==data.Count){
                int currentLength = high - low + 1;
                if(currentLength<minLength){
                    minLength = currentLength;
                    startIndex = low;
                    endIndex = high;
                }
                if(data.ContainsKey(s[low]) && freq[s[low]]==data[s[low]]){
                    match--;
                }
                freq[s[low]]--;
                if(freq[s[low]]==0){
                    freq.Remove(s[low]);
                }
                low++;
                
            }
            high++;
        }
        if(startIndex == -1){
            return "";
        }
        for(int i  = startIndex; i <=endIndex; i++){
            res+=s[i];
        }
        return res;
        
    }
}
