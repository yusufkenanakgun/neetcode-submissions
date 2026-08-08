public class Solution {
    public bool IsValidSudoku(char[][] board) {

        // rows
        for (int i = 0; i < 9; i++) {
            HashSet<char> set = new();
            for (int j = 0; j < 9; j++) {
                char c = board[i][j];
                if (c == '.') continue;
                if (!set.Add(c)) return false;
            }
        }

        // columns
        for (int j = 0; j < 9; j++) {
            HashSet<char> set = new();
            for (int i = 0; i < 9; i++) {
                char c = board[i][j];
                if (c == '.') continue;
                if (!set.Add(c)) return false;
            }
        }

        // boxes
        for (int boxRow = 0; boxRow < 3; boxRow++) {
            for (int boxCol = 0; boxCol < 3; boxCol++) {
                HashSet<char> set = new();
                for (int i = 0; i < 3; i++) {
                    for (int j = 0; j < 3; j++) {
                        char c = board[boxRow * 3 + i][boxCol * 3 + j];
                        if (c == '.') continue;
                        if (!set.Add(c)) return false;
                    }
                }
            }
        }

        return true;
    }
}