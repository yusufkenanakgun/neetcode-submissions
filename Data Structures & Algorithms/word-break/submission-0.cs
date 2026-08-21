public class Solution {
    public bool WordBreak(string s, List<string> wordDict) {
        Dictionary<int, bool> map = new();
        return Foo(s, wordDict, 0, map);
    }
    bool Foo(string s, List<string> wD, int i, Dictionary<int, bool> m) {
        if (i >= s.Length) return true;
        if (m.ContainsKey(i)) return m[i];
        bool flag = false;
        for (int x = 0; x < wD.Count; x++) {
            string sub = "";
            if (i + wD[x].Length <= s.Length) {
                sub = s.Substring(i, wD[x].Length);
            }
            if (sub == wD[x]) {
                flag = (Foo(s, wD, i + wD[x].Length, m) || flag);
            }
        }
        m[i] = flag;
        return m[i];
    }
}
