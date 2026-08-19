public class Solution {
    public int NumDecodings(string s) {
        Dictionary<int, int> map = new(); 
        if (s[0] == '0') return 0;
        return Find(s, 0, map);
    }


    private int Find(string s, int i, Dictionary<int, int> m) {
        if (i >= s.Length) return 1;

        if (m.ContainsKey(i)) return m[i];
        m[i] = 0;
        if (s[i] != '0') {

            m[i] += Find(s, i + 1, m);
        } 
        if (i < s.Length - 1) {
            
            int num = int.Parse("" + s[i] + s[i + 1]);
            if (num > 9 && num < 27) {
                m[i] += Find(s, i + 2, m);
            }
        }
        

        
        return m[i];
    }
}
