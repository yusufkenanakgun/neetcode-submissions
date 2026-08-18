public class Solution {
    public int ClimbStairs(int n) {  
        if (n == 1) return 1;
        if (n == 0) return 0;   
        int[] r = new int[n + 1];
        r[1] = 1;
        r[2] = 2;

        for (int i = 3; i <= n; i++) {
            r[i] = r[i - 1] + r[i - 2];
        }
        return r[n];
    }
}
