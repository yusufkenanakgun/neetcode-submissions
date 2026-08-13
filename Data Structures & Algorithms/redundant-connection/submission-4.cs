public class Solution {
    int[] parent;
    //int size;
    public int[] FindRedundantConnection(int[][] edges) {
        int n = edges.Length;

        parent = new int[n + 1];
        //size = new int[n + 1];

        for (int i = 1; i <= n; i++) {
            parent[i] = i;
            //size[i] = 1;
        }

        foreach ( var e in edges) {
            if (!Union(e[0], e[1])) {
                return e;
            }
        }
        return new int[0];
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
        //size[rootA] += size[rootB];
        return true;
    }

}
