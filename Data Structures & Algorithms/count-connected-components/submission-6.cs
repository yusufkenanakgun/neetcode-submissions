public class Solution {
    int[] parent;
    public int CountComponents(int n, int[][] edges) {
        parent = new int[n];
        HashSet<int> set = new();
        int count = 0;

        for (int i = 0; i < n; i++) {
            parent[i] = i;
        }
        foreach (var e in edges) {
            Union(e[0], e[1]);
        }
        foreach(int item in parent) {
            if (set.Add(Find(item))) count++;
        }
        return count;
    }

    private int Find(int x) {
        if (parent[x] != x) {
            parent[x] = Find(parent[x]);
        }
        return parent[x];
    }
    private void Union(int a, int b) {
        int rootA = Find(a);
        int rootB = Find(b);

        if (rootA == rootB) return;

        parent[rootB] = rootA;
    }
}
