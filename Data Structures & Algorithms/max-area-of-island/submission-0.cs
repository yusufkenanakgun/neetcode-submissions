public class Solution {
    int maxArea = 0;
    int[][] ch;
    int localArea = 0;
    public int MaxAreaOfIsland(int[][] grid) {
        ch = grid;
        for (int i = 0; i < grid.Length; i++) {
            for (int j = 0; j < grid[i].Length; j++) {
                localArea = 0;
                maxArea = Math.Max(maxArea, Paint(i, j));
            }
        }
        return maxArea;
    }

    public int Paint(int i, int j) {
        if (ch[i][j] == 0 || ch[i][j] == 2) return 0;

        localArea++;
        ch[i][j] = 2;
        if (i != 0) Paint(i - 1, j);
        if (j != 0) Paint(i, j - 1);
        if (i != ch.Length - 1) Paint(i + 1, j);
        if (j != ch[0].Length - 1) Paint(i, j + 1);

        return localArea;
    }
}
