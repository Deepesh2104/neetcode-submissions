public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        if(strs == null){
            return new List<List<string>>{
                new List<string>{" "}
            };
        }

        Dictionary<string,List<string>>groupWord = new Dictionary<string,List<string>>();
        foreach(var s in strs)
        {
          char [] ch = s.ToCharArray();
          Array.Sort(ch);
          string key =  new string(ch);
          if(!groupWord.ContainsKey(key)){
            groupWord[key] = new List<string>();
          }
          groupWord[key].Add(s);
           
        }
       return groupWord.Values.ToList();
    }
}
