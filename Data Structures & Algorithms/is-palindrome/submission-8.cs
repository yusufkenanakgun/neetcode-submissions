public class Solution {
    public bool IsPalindrome(string s) {
        char[] ch = s.ToCharArray();
        int a = 0;
        int b = ch.Length - 1;
        while (a < b) {
            while (!char.IsLetterOrDigit(ch[a]) && a < b){
                a++;
            }
            while (!char.IsLetterOrDigit(ch[b]) && a < b){
                b--;
            }
            if ( char.ToLower(ch[a]) != char.ToLower(ch[b]) ){
                return false;
            } else{
                a++;
                b--;
            }
        }
        return true;
    }
}
