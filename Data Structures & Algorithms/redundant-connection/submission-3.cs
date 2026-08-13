public class Solution {
    public int[] FindRedundantConnection(int[][] edges) {
        Dictionary<int, List<int>> map = new();

        for (int i = 0; i < edges.Length; i++) {
            if(IsCycle(map, edges[i][0], edges[i][1])) {
                return edges[i];
            } else {
                if (map.ContainsKey(edges[i][0])) {
                    map[edges[i][0]].Add(edges[i][1]);
                } else {
                    map[edges[i][0]] = new List<int>() {edges[i][1]};
                }
                if (map.ContainsKey(edges[i][1])) {
                    map[edges[i][1]].Add(edges[i][0]);
                } else {
                    map[edges[i][1]] = new List<int>() {edges[i][0]};
                }

            }
        }
        return new int[] {};
    }

    bool IsCycle(Dictionary<int, List<int>> m, int a, int b) {
        if (!m.ContainsKey(a)) {
            return false;
        }

        Queue<int> queue = new();
        HashSet<int> set = new();

        queue.Enqueue(a);
        set.Add(a);

        while (queue.Count != 0) {
            int curr = queue.Dequeue();
            if (curr == b) return true;

            foreach(int item in m[curr]) {
                if ( set.Add(item) ) {
                    queue.Enqueue(item);
                }
            }
            
        }
        return false;
    }
}
