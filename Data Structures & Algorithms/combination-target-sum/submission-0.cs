public class Solution {
    public List<List<int>> CombinationSum(int[] nums, int target) {
        List<List<int>> result = new();
        List<int> list = new();
        int sum = 0;
        Combinations(list, result, nums, 0, sum, target);
        return result;
        
    }

    void Combinations(List<int> l, List<List<int>> r, int[] n, int i, int s, int t) {
        
        for (int x = i; x < n.Length; x++) {
            l.Add(n[x]);
            s += n[x];
            if (s == t) {
                r.Add(new List<int>(l));
                l.RemoveAt(l.Count - 1);
                s -= n[x];
            } else if (s < t) {
                Combinations(l, r, n, x, s, t);
                l.RemoveAt(l.Count - 1);
                s -= n[x];
            } else {
                l.RemoveAt(l.Count - 1);
                s -= n[x];
            }
        }

        
    }
}
