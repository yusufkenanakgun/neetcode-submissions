public class Solution {
    public int CoinChange(int[] coins, int amount) {
        Dictionary<int, int> map = new();
        return Foo(coins, amount, map);

    }
    int Foo(int[] c, int a, Dictionary<int, int> m) {
        if (a == 0) return 0;
        if (m.ContainsKey(a)) return m[a];
        int b = int.MaxValue;
        for (int i = c.Length - 1; i >= 0; i--) {
            if (c[i] <= a) {
                int child = Foo(c, a - c[i], m);
                if (child != -1) {
                    b = Math.Min(child + 1, b);
                }
            }
        }

        if (b == int.MaxValue) {
            m[a] = -1;
        } else {
            m[a] = b;
        }
        return m[a];
    }
}
