public class Solution {
    public int Rob(int[] nums) {
        if (nums.Length == 1) return nums[0];
        Dictionary<int, int> map = new();
        int first = Find(nums, 0, nums.Length - 2, map);
        map = new();
        int second = Find(nums, 1, nums.Length - 1, map);
        return Math.Max(first, second);
    }
    int Find(int[] n, int l, int r, Dictionary<int, int> m) {
        if ( l > r) return 0;
        if (m.ContainsKey(r)) return m[r];

        m[r] = Math.Max(Find(n, l, r - 2, m) + n[r], Find(n, l, r - 1, m));
        return m[r];
    }
}
