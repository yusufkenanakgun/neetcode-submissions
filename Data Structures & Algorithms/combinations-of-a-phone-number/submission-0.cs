public class Solution {
    public List<string> LetterCombinations(string digits) {
        if (digits.Length == 0) return new List<string>();

        List<string> result = new();
        Dictionary<char, string> map = new() {
            {'2',"abc"}, {'3',"def"}, {'4',"ghi"}, {'5',"jkl"},
            {'6',"mno"}, {'7',"pqrs"}, {'8',"tuv"}, {'9',"wxyz"}
        };
        Find(map, digits, 0, "", result);

        return result;
        
    }
    private void Find(Dictionary<char, string> m, string d, int i, string c, List<string> r) {
        if (i == d.Length) { r.Add(c); return; }

        for (int x = 0; x < m[d[i]].Length; x++) {
            c = c + m[d[i]][x];
            Find(m, d, i + 1, c, r);
            if (c.Length >= 2) {
                c = c.Substring(0, c.Length - 1);
            } else {
                c = "";
            }
        }

    }
}
