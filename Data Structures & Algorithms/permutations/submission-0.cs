public class Solution {
    public List<List<int>> Permute(int[] nums) {
        List<List<int>> result = new();

        FindPer(new List<int>(), result, new HashSet<int>(), nums);
        return result;
    }


    void FindPer(List<int> l, List<List<int>> r, HashSet<int> s, int[] n) {
        if (l.Count == n.Length) { r.Add(new List<int>(l)); return; }

        for (int x = 0; x < n.Length; x++) {
            if (s.Add(n[x])) {
                l.Add(n[x]);
                FindPer(l, r, s, n);
                l.RemoveAt(l.Count - 1);
                s.Remove(n[x]);
            }
            
            
        }
    }
}
