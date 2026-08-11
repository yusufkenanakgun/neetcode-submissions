public class Solution {
    public List<List<int>> PacificAtlantic(int[][] heights) {
        bool[,] pac = new bool[heights.Length, heights[0].Length];
        bool[,] atl = new bool[heights.Length, heights[0].Length];
        
        List<List<int>> result = new();

        for (int i = 0; i < heights.Length; i++) {
            if (i == 0) {
                for (int j = 0; j < heights[0].Length; j++) {
                    pac[i,j] = true;
                    Flow(heights, i, j, pac);
                }
            } else {
                pac[i,0] = true;
                Flow(heights, i, 0, pac);
            }  
        }
        for (int i = heights.Length - 1; i >= 0 ; i--) {
            if (i == heights.Length - 1) {
                for (int j = heights[0].Length - 1; j >= 0 ; j--) {
                    atl[i,j] = true;
                    Flow(heights, i, j, atl);
                }
            } else {
                atl[i, heights[0].Length - 1] = true;
                Flow(heights, i, heights[0].Length - 1, atl);
            }  
        }
        for (int i = 0; i < heights.Length; i++) {
            for (int j = 0; j < heights[0].Length; j++) {
                if(pac[i, j] && atl[i, j]) result.Add([i, j]);
            } 
        }
        return result;
        
    }

    void Flow(int[][] h, int row, int col, bool[,] sea) {
        Queue<(int r, int c)> queue = new();

        queue.Enqueue((row, col));

        while (queue.Count != 0) {
            var (r, c) = queue.Dequeue();

            if (r != 0 && !sea[r - 1, c] && h[r][c] <= h[r-1][c]) {
                sea[r - 1, c] = true;
                queue.Enqueue((r-1, c));
            }
            if (c != 0 && !sea[r , c-1] && h[r][c] <= h[r][c-1]) {
                sea[r , c-1] = true;
                queue.Enqueue((r, c-1));
            }
            if (r != h.Length - 1 && !sea[r + 1, c] && h[r][c] <= h[r+1][c]) {
                sea[r + 1, c] = true;
                queue.Enqueue((r+1, c));
            }
            if (c != h[0].Length - 1 && !sea[r , c+1] && h[r][c] <= h[r][c+1]) {
                sea[r , c+1] = true;
                queue.Enqueue((r, c+1));
            }
        }
    }
}
