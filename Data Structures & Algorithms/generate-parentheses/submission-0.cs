public class Solution {  
    public List<string> GenerateParenthesis(int n) {
        List<string> list = new();
        string current = "";
        int open = 0;
        int close = 0;


        void Backtrack(string current, int open, int close){
            if (current.Length == 2*n){
                list.Add(current);
                return;
            }

            if (open < n){
                Backtrack(current + '(' , open + 1 , close);
            }

            if (close < open){
                Backtrack(current + ')' , open , close + 1);
            }
        }
        
        Backtrack(current, open, close);
        return list;
    }
}
