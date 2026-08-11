public class Solution {
    public void islandsAndTreasure(int[][] grid) {
        Queue<(int row, int col)> queue = new();


        for (int i = 0; i < grid.Length; i++) {
            for (int j = 0; j < grid[0].Length; j++) {
                if (grid[i][j] == 0) queue.Enqueue((i, j));
            }
        }

        while (queue.Count != 0) {
            int count = queue.Count;
            int value = int.MaxValue;

            for (int i = 0; i < count; i++) {
                var (r, c) = queue.Dequeue();
                if (r != 0 && grid[r - 1][c] != - 1 && grid[r - 1][c] == value) {
                    grid[r-1][c] = grid[r][c] + 1;
                    queue.Enqueue((r-1,c));
                }
                if (c != 0 && grid[r][c-1] != - 1 && grid[r][c-1] == value) {
                    grid[r][c-1] = grid[r][c] + 1;
                    queue.Enqueue((r,c-1));
                }
                if (r != grid.Length - 1 && grid[r + 1][c] != - 1 && grid[r + 1][c] == value) {
                    grid[r+1][c] = grid[r][c] + 1;
                    queue.Enqueue((r+1,c));
                }
                if (c != grid[0].Length - 1 && grid[r ][c+1] != - 1 && grid[r][c+1] == value) {
                    grid[r][c+1] = grid[r][c] + 1;
                    queue.Enqueue((r,c+1));
                }
            }
        }
        
    }
}
