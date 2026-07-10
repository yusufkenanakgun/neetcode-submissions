public class Solution {
    public int FindDuplicate(int[] nums) {
        int slow = 0, fast = 0;

    // Phase 1: find a meeting point
        do {
            slow = nums[slow];
            fast = nums[nums[fast]];
        } while (slow != fast);

    // Phase 2: find the entrance to the cycle
        int slow2 = 0;
        while (slow2 != slow) {
            slow = nums[slow];
            slow2 = nums[slow2];
        }
        return slow;
    }
}
