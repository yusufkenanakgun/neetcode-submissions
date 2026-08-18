public class Solution {
    public int Rob(int[] nums) {
        if (nums.Length == 1) return nums[0];
        Dictionary<int, int> map = new();
        int left = Robb(map, nums, 0, nums.Length - 2);
        map = new();
        int right = Robb(map, nums, 1, nums.Length - 1);
        return Math.Max(left, right);
    }
    int Robb(Dictionary<int, int> m, int[] n,int l, int r) {
        if (m.ContainsKey(r)) return m[r];
        
        if ( r < l ) return 0;
        m[r] = Math.Max(Robb(m, n, l, r - 1), Robb(m, n, l, r - 2) + n[r]);
        return m[r];
    }
}
