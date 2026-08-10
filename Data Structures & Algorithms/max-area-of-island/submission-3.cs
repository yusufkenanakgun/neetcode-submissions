public class Solution {
    int[][] ch;

    public int MaxAreaOfIsland(int[][] grid) {
        int maxArea = 0;
        ch = grid;
        for (int i = 0; i < grid.Length; i++) {
            for (int j = 0; j < grid[0].Length; j++) {
                maxArea = Math.Max(maxArea, Paint(i, j));
            }
        }
        return maxArea;
    }

    public int Paint(int i, int j) {
        if ( i < 0 || j < 0 || i > ch.Length - 1 || j > ch[0].Length - 1) return 0;
        if (ch[i][j] == 0 || ch[i][j] == 2) return 0;
        
        ch[i][j] = 2;

        return Paint(i - 1, j) + Paint(i, j - 1) + Paint(i + 1, j) + Paint(i, j + 1) + 1;
    }
}
