public class Solution {
    int[] parent;
    
    public bool ValidTree(int n, int[][] edges) {
        if (edges.Length != n - 1) {
            return false;
        }
        parent = new int[n];

        for (int i = 0; i < n; i++) {
            parent[i] = i;
        }
        int count = n;
        foreach (var e in edges) {
            if (Union(e[0], e[1])) count--;
        }
        return (count <= 1);
    }

    private int Find(int x) {
        if (parent[x] != x) {
            parent[x] = Find(parent[x]);
        }
        return parent[x];
    }
    private bool Union(int a, int b) {
        int rootA = Find(a);
        int rootB = Find(b);

        if (rootA == rootB) return false;

        parent[rootB] = rootA;
        return true;
    }
}
