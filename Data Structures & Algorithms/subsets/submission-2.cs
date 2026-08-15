public class Solution {
    public List<List<int>> Subsets(int[] nums) {
        List<int> list = new();
        List<List<int>> result = new();

        return CreateSubsets(nums, 0, list, result);
    }

    List<List<int>> CreateSubsets(int[] n, int i, List<int> l, List<List<int>> r) {
        r.Add(new List<int>(l));

        while (i < n.Length) {
            l.Add(n[i]);
            CreateSubsets(n, i + 1, l, r);
            l.Remove(n[i]);
            i++;
        }
        
        
        return r;
    }
}
