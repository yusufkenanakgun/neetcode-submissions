public class Solution {
    public int MinCostClimbingStairs(int[] cost) {
        Dictionary<int, int> map = new();
        return MinS(cost, cost.Length, map);

       
    }
    int MinS(int[] cost, int c, Dictionary<int, int> m) {
        if(m.ContainsKey(c)) return m[c];
        if (c < 0) return 0;
        int a = 0;
        if (c != cost.Length) a = cost[c];
        m[c] = Math.Min(MinS(cost, c - 1, m), MinS(cost, c - 2, m)) + a;
        return m[c];
    }
    
}
