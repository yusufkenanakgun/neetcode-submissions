public class Solution {
    public int ClimbStairs(int n) {
        int[] cache = new int[n + 1];
        //if (n == 0) return 0;
        return Climb(n, cache);
    }
    int Climb(int n, int[] cache) {
        if (n <= 1) return 1;
        if (cache[n] != 0) return cache[n];
        cache[n] = Climb(n - 1, cache) + Climb(n - 2, cache);
        return cache[n];
    }
}
