public class Solution {

    public string Encode(IList<string> strs) {
        string s = "";

        for (int i = 0; i < strs.Count; i++) {
            s = s + strs[i].Length + '#' + strs[i];
        }
        return s;
        
    }

    public List<string> Decode(string s) {
        string str = "";
        List<string> result = new();
        int count = 0;
        string countS = "";
        int i = 0;
        
        while ( i < s.Length) {
            if ( s[i] != '#' ) {
                countS += s[i];
                i++;
            } else {
                count = int.Parse(countS);
                i++;
                countS = "";
                while ( count > 0 ) {
                    str += s[i];
                    i++;
                    count--;
                }
                result.Add(str);
                str = "";
            }
        }
        return result;
   }
}
