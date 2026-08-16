public class Solution {
    public List<List<int>> CombinationSum(int[] nums, int target) {
        Array.Sort(nums);
        List<List<int>> result = new();
        List<int> list = new();

        Combinations(list, result, nums, 0, 0, target);
        return result;
        
    }

    void Combinations(List<int> l, List<List<int>> r, int[] n, int i, int s, int t) {
        if (s == t) { r.Add(new List<int>(l)); return; }
        
        for (int x = i; x < n.Length; x++) {
            if (s + n[x] > t) break;

            l.Add(n[x]);
            Combinations(l, r, n, x, s + n[x], t);
            l.RemoveAt(l.Count - 1);
        }

        
    }
}
