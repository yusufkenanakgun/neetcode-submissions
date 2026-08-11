public class Solution {
    static readonly int[][] Dirs = [[-1,0],[1,0],[0,-1],[0,1]];

    public void Solve(char[][] board) {
        bool[,] visited = new bool[board.Length, board[0].Length];

        for ( int i = 0; i < board.Length; i++ ) {
            for (int j = 0; j < board[0].Length; j++ ) {
                if ( board[i][j] == 'O' && !visited[i, j]) {
                    Paint(board, i, j, visited);
                }
            }
        }      
    }

    void Paint(char[][] b, int row, int col, bool[,] v) {
        Queue <(int r, int c)> queue = new();
        Queue <(int r2, int c2)> queue2 = new();
        bool survive = false;

        queue.Enqueue((row, col));
        queue2.Enqueue((row, col));
        v[row, col] = true;

        while (queue.Count != 0) {
            var (r, c) = queue.Dequeue();
            b[r][c] = 'X';
            foreach (var d in Dirs)
            {
                int nr = r + d[0], nc = c + d[1];
                if (nr < 0 || nr >= b.Length || nc < 0 || nc >= b[0].Length) {
                    survive = true;
                    continue;
                }
                
                if ( b[nr][nc] == 'O' && !v[nr,nc]) {
                    v[nr,nc] = true;
                    queue.Enqueue((nr, nc));
                    queue2.Enqueue((nr, nc));
                }
            }
        }
        if (survive) {
            foreach (var (r, c) in queue2) {
                b[r][c] = 'O';
            }
        }
        
    }
}




