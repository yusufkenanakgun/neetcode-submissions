public class Solution {
    public bool IsAnagram(string s, string t) {
        if ( s.Length != t.Length ) return false;

        Dictionary <char , int> dic1 = new();
        Dictionary <char , int> dic2 = new();
        char[] ch1 = s.ToCharArray();
        char[] ch2 = t.ToCharArray();
        foreach (char c in ch1) {
            if (!dic1.ContainsKey(c)) dic1.Add(c, 1);
            else dic1[c]++;
        }
        foreach (char c in ch2) {
            if (!dic2.ContainsKey(c)) dic2.Add(c, 1);
            else dic2[c]++;
        }
        foreach (char c in dic1.Keys) {
            if (!dic2.ContainsKey(c)){
                return false;
            } else if (dic1[c] != dic2[c]) {
                return false;
            }
        }
        return true;
    }
}
