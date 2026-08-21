public class Solution {
    public int NumDecodings(string s) {
        Dictionary<int, int> map = new();
        return Find(s, 0, map);
    }
    int Find(string s, int d, Dictionary<int, int> m) {
        if (d >= s.Length) return 1;
        if (m.ContainsKey(d)) return m[d];
        int a = 0, b = 0;
        if (s[d] != '0') {
            a = Find(s, d + 1, m);
            if (d != s.Length - 1) {
                int num = int.Parse("" + s[d] + s[d+1]);
                if (num < 27) {
                    b =  Find(s, d + 2, m);
                }
            }
            
        }
        m[d] = a + b;
        return m[d];
    }
}
