public class Solution {
    public bool IsAnagram(string s, string t) {

        if(s.Length !=t.Length){
            return false;
        }
        Dictionary<char,int>str1 = new Dictionary<char,int>();
        Dictionary<char,int>str2 = new Dictionary<char,int>();

        for(int i = 0;i<s.Length;i++){
            if(str1.ContainsKey(s[i])){
                str1[s[i]]++;
                
            }else{
                
                str1[s[i]]=1;
            }
        }
        
        for(int i = 0;i<t.Length;i++){
            if(str2.ContainsKey(t[i])){
                str2[t[i]]++;
            }else{
                str2[t[i]]=1;
            }
        }
       
        foreach(var item in str1){
            if(!str2.ContainsKey(item.Key)){
                return false;
            }
            if(str2[item.Key]!=item.Value) return false;
        }
        return true;
    
    }
}
