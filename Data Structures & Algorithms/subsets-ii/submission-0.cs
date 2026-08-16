public class Solution {
    public List<List<int>> SubsetsWithDup(int[] nums) {
        Array.Sort(nums);
        List<List<int>> result = new();

        Combinations(new List<int>(), result, nums, 0);
        return result;
    }

    private void Combinations(List<int> l, List<List<int>> r, int[] n, int i) {
        r.Add(new List<int>(l));


        for (int x = i; x < n.Length; x++) {
            if ( x > i && n[x] == n[x - 1]) continue;
            l.Add(n[x]);
            Combinations(l, r, n, x + 1);
            l.RemoveAt(l.Count - 1);
        }
    }
}
