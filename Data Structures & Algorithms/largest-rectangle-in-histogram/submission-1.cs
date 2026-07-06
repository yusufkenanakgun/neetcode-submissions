public class Solution {
    public int LargestRectangleArea(int[] heights) {
        int maxArea = 0;
        var stack = new Stack<int>();

        for (int i = 0; i <= heights.Length; i++){
            int cur = (i == heights.Length) ? 0 : heights[i];

            while (stack.Count > 0 && cur < heights[stack.Peek()]){
                int j = stack.Pop();
                int h = heights[j];
                int width = (stack.Count == 0) ? i : i - stack.Peek() - 1;
                maxArea = Math.Max(maxArea, h * width); 
            }
            stack.Push(i);

        }

        return maxArea;
        
    }
}
