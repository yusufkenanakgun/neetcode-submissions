public class Solution {
    public int MaxArea(int[] heights) {
        int area = 0;
        int a = 0;
        int b = heights.Length -1;

        while (a < b) {
            int current = (b - a ) * Math.Min(heights[a], heights[b]);
            if (current > area ){
                area = current;
            }
            if (heights[a] < heights[b]){
                a++;
            }else {
                b--;
            }
        }
        return area;
        
    }
}
