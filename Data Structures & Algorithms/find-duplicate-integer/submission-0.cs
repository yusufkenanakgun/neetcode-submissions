public class Solution {
    public int FindDuplicate(int[] nums) {
        HashSet<int> set = new();
        for (int i = 0; i < nums.Length; i++) {
            if (!set.Contains(nums[i])) {
                set.Add(nums[i]);
            }
            else {
                return nums[i];
            }
        }
        return -1;
    }
}
