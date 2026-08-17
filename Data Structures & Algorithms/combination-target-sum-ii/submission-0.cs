public class Solution {
    public List<List<int>> CombinationSum2(int[] candidates, int target) {
        Array.Sort(candidates);
        List<List<int>> result = new();

        Combinations(new List<int>(), result, candidates, 0, 0, target);
        return result;     
    }

    private void Combinations(List<int> l, List<List<int>> r, int[] c, int i, int s, int t) {
        if (s == t) { r.Add(new List<int>(l)); return; }

        for (int x = i; x < c.Length; x++) {
            if (s + c[x] > t) break;
            if (x > i && c[x] == c[x - 1]) continue;

            l.Add(c[x]);
            Combinations(l, r, c, x + 1, s + c[x], t);
            l.RemoveAt(l.Count - 1);
        }
    }
}
