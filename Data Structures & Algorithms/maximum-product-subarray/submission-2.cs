public class Solution {
    static int maximum = int.MinValue; 
    public int MaxProduct(int[] nums) {
        Dictionary<int, (int, int)> map = new();
        
        Foo(nums, 0, map);
        return maximum;
    }

    (int, int) Foo(int[] n, int i, Dictionary<int, (int, int)> m) {
        if (i >= n.Length - 1) {
            maximum = n[n.Length - 1];
            return (n[n.Length - 1], n[n.Length - 1]);
        }
        if (m.ContainsKey(i)) return m[i];

        var (min, max) = Foo(n, i + 1, m);

        int subMin = Math.Min(min*n[i], Math.Min(max*n[i], n[i]));
        int subMax = Math.Max(min*n[i], Math.Max(max*n[i], n[i]));
        maximum = Math.Max(maximum, subMax);
        m[i] = (subMin, subMax);
        return m[i];
    }
}
