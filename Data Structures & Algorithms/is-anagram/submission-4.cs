public class Solution {
    public bool IsAnagram(string s, string t) {
        Dictionary<char,int>sFreq = new Dictionary<char,int>();
        Dictionary<char,int>tFreq = new Dictionary<char,int>();
        if(s.Length!=t.Length){
            return false;
        }
        foreach(char c in s){
            if(sFreq.ContainsKey(c)){
                sFreq[c]++;
            }else{
                sFreq[c] =1;
            }
        }
        foreach(char c in t){
            if(tFreq.ContainsKey(c)){
                tFreq[c]++;
            }else{
                tFreq[c] =1;
            }
        }
        Console.WriteLine("Printing First Dictionary");
        foreach(var item in sFreq){
            Console.WriteLine($"{item.Key} Value {item.Value}");
        }
        Console.WriteLine("Printing Second Dictionary");
        foreach(var item in tFreq){
            Console.WriteLine($"{item.Key} Value {item.Value}");
        }
        
        foreach(var item in sFreq){
            if(!tFreq.ContainsKey(item.Key)){
                return false;
            }
            if(tFreq[item.Key]!=item.Value){
                    return false;
            }
        }
        return true;
    }
}
