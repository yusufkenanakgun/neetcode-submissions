public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string , List<string>> map = new();
        List<List<string>> list = new();

        for (int i = 0; i < strs.Length ; i++) {
            char[] ch = strs[i].ToCharArray();
            Array.Sort(ch);
            string key = new string(ch);
            if (!map.ContainsKey(key)) {
                map.Add(key, new List<string>() {strs[i]});
            }
            else {
                map[key].Add(strs[i]);
            }
        }
        foreach (string s in map.Keys){
            list.Add(map[s]);
        }
        return list;
        

    }
}
