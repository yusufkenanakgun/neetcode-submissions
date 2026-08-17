public class Solution {
    public static readonly int[][] Dirs = new int[][]
    {
        new int[] { 1, 0 },
        new int[] { -1, 0 },
        new int[] { 0, 1 },
        new int[] { 0, -1 }
    };

    public bool Exist(char[][] board, string word) {
        int row = board.Length, col = board[0].Length;

        for (int i = 0; i < row; i++) {
            for (int j = 0; j < col; j++) {
                if (board[i][j] == word[0] && IfExist(board, word, i, j, 1, new HashSet<(int, int)>())) {
                    return true;
                }
            }
        }
        return false;
    }

    bool IfExist(char[][] b, string w, int r, int c, int d, HashSet<(int, int)> s) {
        s.Add((r, c));
        if (d == w.Length) return true;


        foreach(var item in Dirs) {
            int nr = item[0] + r, nc = item[1] + c;
            if (nr < 0 || nr == b.Length || nc < 0 || nc == b[0].Length) continue;
            if (b[nr][nc] == w[d] && s.Add((nr, nc))) {
                if (IfExist(b, w, nr, nc, d + 1, s)) return true;
            }
        }
        s.Remove((r, c));
        return false;
    }
}
