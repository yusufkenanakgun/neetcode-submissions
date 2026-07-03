public class Solution {
    public int LongestConsecutive(int[] nums) {
        int count = 0;
        int maxCount = 0;
        Array.Sort(nums);
        HashSet<int> set = new(nums);
        foreach (int item in set) {
            if (!set.Contains(item - 1)){
                count = 1;
            }else {
                count++;
            }
            maxCount = Math.Max(count, maxCount);
        } 
        return maxCount;
    }
}
