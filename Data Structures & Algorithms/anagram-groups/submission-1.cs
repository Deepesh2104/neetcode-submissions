public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
       if(strs == null){
        return new List<List<string>>{
            new List<string>{""}
        };
       }

       Dictionary<string,List<string>>anagram = new Dictionary<string,List<string>>();
       foreach(var s in strs){
        char [] ch = s.ToCharArray();
        Array.Sort(ch);
        string key = new string(ch);

        if(!anagram.ContainsKey(key)){
            anagram[key] = new List<string>();
        }
        anagram[key].Add(s);
       }
       return anagram.Values.ToList();
    }
}
