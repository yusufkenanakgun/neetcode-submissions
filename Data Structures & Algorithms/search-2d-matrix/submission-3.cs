public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        if (matrix.Length == 0) {
            return true;
        }
        int start = 0;
        int finish = matrix.Length * matrix[0].Length - 1;

        while ( start <= finish ) {
            int mid = start + (finish - start) / 2 ;

            int row = mid / matrix[0].Length ;
            int col = mid % matrix[0].Length ;

            if ( matrix[row][col] == target){
                return true;
            } else if ( matrix[row][col] > target) {
                finish = mid - 1;
            } else {
                start = mid + 1;
            }


        }

        return false;
        
    }
}
