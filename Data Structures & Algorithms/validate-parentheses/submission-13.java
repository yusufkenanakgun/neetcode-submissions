class Solution {
    public boolean isValid(String s) {
        char[] c = s.toCharArray();
        Deque<Character> stack = new ArrayDeque<>();

        for(int i = 0 ; i < c.length ; i++){
            if(c[i] == '[' || c[i] == '(' || c[i] == '{'){
                stack.push(c[i]);
            }else if (c[i] == ']' || c[i] == ')' || c[i] == '}'){
                if (stack.isEmpty()) return false;
                if (c[i] == ')' && stack.peek() == '(') stack.pop();
                else if (c[i] == ']' && stack.peek() == '[') stack.pop();
                else if (c[i] == '}' && stack.peek() == '{') stack.pop();
                else return false;
            }else{
                return false;
            }     
        }
        return stack.isEmpty();
    }
}
