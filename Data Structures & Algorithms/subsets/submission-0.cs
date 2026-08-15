public class Solution {
    public List<List<int>> Subsets(int[] nums) {
        List<int> list = new();
        List<List<int>> result = new();
        Queue<int> queue = new();

        for (int i = 0; i < nums.Length; i++) {
            queue.Enqueue(nums[i]);
        }

        return CreateSubsets(list, result, queue);
    }

    List<List<int>> CreateSubsets(List<int> l, List<List<int>> r, Queue<int> q) {
        r.Add(new List<int>(l));

        while (q.Count != 0) {
            int curr = q.Dequeue();
            l.Add(curr);
            CreateSubsets(l, r, new Queue<int>(q));
            l.Remove(curr);
        }
        
        return r;
    }
}
