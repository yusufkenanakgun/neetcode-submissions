public class Solution {
    public int MinCostClimbingStairs(int[] cost) {
        Dictionary<int, int> map = new();
        return Math.Min(MinCost(cost, 0, map), MinCost(cost, 1, map));
    }

    int MinCost(int[] c, int d, Dictionary<int, int> m) {
        if (d >= c.Length) return 0;
    
        if (m.ContainsKey(d)) return m[d];
        
        m[d] = Math.Min(MinCost(c, d + 1, m), MinCost(c, d + 2, m)) + c[d];
        return m[d];
    }
}
