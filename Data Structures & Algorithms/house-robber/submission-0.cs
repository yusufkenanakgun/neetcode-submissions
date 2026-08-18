public class Solution {
    public int Rob(int[] nums) {
        Dictionary<int, int> map = new();
        return Robb(map, nums, nums.Length - 1);        
    }

    private int Robb(Dictionary<int, int> m, int[] n, int c) {
        if (m.ContainsKey(c)) return m[c];
        if (c < 0) return 0;
        int a = 0;
        if (c < n.Length) a = n[c];
        m[c] = Math.Max(Robb(m, n, c - 1), Robb(m, n, c - 2) + n[c]);
        return m[c];
    }
}
