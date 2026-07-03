public class Solution {
    public bool IsValid(string s) {
        if (s.Length == 0){
            return true;
        }
        Stack<char> stack = new();
        for (int i = 0; i < s.Length ; i++) {
            if (stack.Count == 0 && (s[i] == ')' || s[i] == '}' || s[i] == ']') ){
                return false;
            }
            if (s[i] == '(' || s[i] == '{' || s[i] == '['){
                stack.Push(s[i]);
            } else if (s[i] == ')' && stack.Peek() == '('){
                stack.Pop();
            } else if (s[i] == '}' && stack.Peek() == '{'){
                stack.Pop();
            } else if (s[i] == ']' && stack.Peek() == '['){
                stack.Pop();
            } else {
                return false;
            }
        }
        if (stack.Count > 0){
            return false;
        } else {
            return true;
        }
    }
}
