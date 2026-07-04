public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> stack = new();


        for (int i = 0; i < tokens.Length ; i++){
            if (tokens[i] == "+" || tokens[i] == "-" || tokens[i] == "*" || tokens[i] == "/") {
                if (tokens[i] == "+"){
                    int a = stack.Pop();
                    int b = stack.Pop();
                    stack.Push(a+b);
                } else if (tokens[i] == "-"){
                    int a = stack.Pop();
                    int b = stack.Pop();
                    stack.Push(b-a);
                } else if (tokens[i] == "*"){
                    int a = stack.Pop();
                    int b = stack.Pop();
                    stack.Push(a*b);
                } else if (tokens[i] == "/"){
                    int a = stack.Pop();
                    int b = stack.Pop();
                    stack.Push(b/a);
                }
            } else {
                stack.Push(int.Parse(tokens[i]));
            }
        }

        return stack.Peek();
    }
}
