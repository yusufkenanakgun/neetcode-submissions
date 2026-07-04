public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        int[] result = new int[temperatures.Length];
        Stack<int> stack = new();


        for (int i = 0; i < temperatures.Length; i++){

            while (stack.Count > 0 && temperatures[stack.Peek()] < temperatures[i] ){
                    int j = stack.Pop();
                    result[j] = i - j;
            }
            
            stack.Push(i);
        }

        return result;
    }
}
