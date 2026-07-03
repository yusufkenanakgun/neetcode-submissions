public class Solution {
    public int CharacterReplacement(string s, int k) {
        
        int[] count = new int[26];
        int left = 0;
        int maxCount = 0;
        int answer = 0;

        for (int right = 0 ; right < s.Length ; right++) {
            count[s[right]-'A']++;
            maxCount = Math.Max(maxCount , count[s[right]-'A']);

            int winLength = right - left + 1;

            if ( winLength - maxCount > k){
                count[s[left]-'A']--;
                left++;
                winLength--;
            }
            answer = Math.Max(answer, winLength);
        }
        return answer;
    }
}
