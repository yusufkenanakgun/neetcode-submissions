public class Solution {

    public int OrangesRotting(int[][] grid) {
        Queue<(int row, int col)> queue = new();

        for (int i = 0; i < grid.Length; i++) {
            for (int j = 0; j < grid[0].Length; j++) {
                if (grid[i][j] == 2) queue.Enqueue((i, j));
            }
        }

        int max = Rott(queue, grid);


        for (int i = 0; i < grid.Length; i++) {
            for (int j = 0; j < grid[0].Length; j++) {
                if (grid[i][j] == 1) max = -1;
            }
        }
        return max;
    }

    public int Rott(Queue <(int row, int col)> queue, int[][] ch) {
        int second = 0;

        while(queue.Count != 0) {
            int count = queue.Count;
            bool rotted = false; 

            while (count > 0) {
                var tuple = queue.Dequeue();

                if (tuple.row != 0) {
                    if (ch[tuple.row - 1][tuple.col] == 1 ){
                        ch[tuple.row - 1][tuple.col] = 2;
                        queue.Enqueue((tuple.row-1, tuple.col));
                        rotted = true;
                    } 
                }
                    if (tuple.col != 0) {
                    if (ch[tuple.row ][tuple.col-1] == 1 ){
                        ch[tuple.row][tuple.col-1] = 2;
                        queue.Enqueue((tuple.row, tuple.col -1));
                        rotted = true;
                    } 
                }
                if (tuple.row != ch.Length - 1 ) {
                    if (ch[tuple.row + 1][tuple.col] == 1 ){
                        ch[tuple.row + 1][tuple.col] = 2;
                        queue.Enqueue((tuple.row+1, tuple.col));
                        rotted = true;
                    } 
                }
                if (tuple.col != ch[0].Length - 1 ) {
                    if (ch[tuple.row ][tuple.col+1] == 1 ){
                        ch[tuple.row ][tuple.col+1] = 2;
                        queue.Enqueue((tuple.row, tuple.col+1));
                        rotted = true;
                    } 
                }
                count--;
            }
            
            if(rotted) second++;

        }

        return second;
    }
}
