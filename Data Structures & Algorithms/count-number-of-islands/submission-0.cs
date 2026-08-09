public class Solution {
    int count = 0;
    char[][] ch;
    
    public int NumIslands(char[][] grid) {
        ch = grid;

        for (int i = 0; i < grid.Length; i++) {
            for (int j = 0; j < grid[0].Length; j++) {
                if (grid[i][j] == '0' || grid[i][j] == '2') {
                    continue;
                } else {
                    count++;
                    Paint(i, j);
                }
            }
        }


        return count;
    }

    int Paint (int i, int j) {
        if(ch[i][j] == '0' || ch[i][j] == '2') return 0;

        if (ch[i][j] == '1') ch[i][j] = '2'; 

        if ( i != 0) {
            Paint(i - 1, j);
        }
        if ( j != 0) {
            Paint(i , j - 1);
        }
        if ( i != ch.Length - 1) {
            Paint(i + 1, j);
        }
        if ( j != ch[0].Length - 1) {
            Paint(i, j + 1);
        }
        return 1;
    }            
}
