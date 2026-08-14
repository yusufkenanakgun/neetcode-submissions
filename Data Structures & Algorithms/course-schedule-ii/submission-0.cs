public class Solution {
    public int[] FindOrder(int numCourses, int[][] prerequisites) {
        Dictionary<int, HashSet<int>> map = new();
        int[] indegree = new int[numCourses];
        List<int> validOrder = new();
        Queue<int> q = new();

        foreach (var item in prerequisites) {
            int a = item[0], b = item[1];
            indegree[a]++;
            if (!map.ContainsKey(b)) {
                map[b] = new HashSet<int>() {a};
            } else {
                map[b].Add(a);
            }
        }
        for (int i = 0; i < indegree.Length; i++) {
            if (indegree[i] == 0) {
                q.Enqueue(i);
            }
        }
        int count = 0;
        while (q.Count != 0) {
            int curr = q.Dequeue();
            validOrder.Add(curr);
            count++;
            if (map.ContainsKey(curr)) {
                foreach (int item in map[curr]) {
                    indegree[item]--;
                    if (indegree[item] == 0) {
                        q.Enqueue(item);
                    }
                }
            }
            
        }
        if (count == numCourses) {
            return validOrder.ToArray();
        } else {
            return new int[0];
        }
    }
}
