public class Solution {
    public int Search(int[] nums, int target) {
        int start = 0;
        int finish = nums.Length - 1;

        while (start < finish) {
            int mid = (start + finish) / 2;
            if (nums[mid] > nums[finish]) {
                if (nums[start] <= target && nums[mid] >= target) {
                    finish = mid;
                } else {
                    start = mid + 1;
                }
            } else {
                if (nums[mid] < target && nums[finish] >= target) {
                    start = mid + 1;
                } else {
                    finish = mid;
                }
            }
        }
        return (nums[start] == target) ? start : -1;
    }
}
