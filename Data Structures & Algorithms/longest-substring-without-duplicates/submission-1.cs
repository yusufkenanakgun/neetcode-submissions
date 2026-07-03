public class Solution {
    public int LengthOfLongestSubstring(string s) {
        char[] ch = s.ToCharArray();
        Dictionary<char , int> map = new();

        int longest = 0;
        int based = 0; 

        for (int i = 0; i < ch.Length ; i++) {
            if (!map.ContainsKey(ch[i])){
                map.Add(ch[i], i);
            } else if (map[ch[i]] >= based ) {
                based = map[ch[i]] + 1;
                map.Remove(ch[i]);
                map.Add(ch[i], i);
            } else {
                map.Remove(ch[i]);
                map.Add(ch[i], i);
            }

            longest = Math.Max(longest, i - based + 1);
        }
        return longest;
    }
}
