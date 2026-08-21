public class Solution {
    public int Rob(int[] nums) {
        Dictionary<int, int> map = new();
        return Find(nums, 0, map);
    }
    int Find(int[] n, int d, Dictionary<int, int> m) {
        if (d >= n.Length) return 0;
        if (m.ContainsKey(d)) return m[d];
        
        m[d] = Math.Max(Find(n, d + 2, m) + n[d], Find(n, d + 1, m));
        return m[d];
    }
}
