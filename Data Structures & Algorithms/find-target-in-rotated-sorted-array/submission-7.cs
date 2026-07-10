public class Solution {
    public int Search(int[] nums, int target) {
        int start = 0, finish = nums.Length - 1;

        while (start < finish) {
            int mid = (start + finish) / 2;

            if (nums[mid] < nums[finish]) {
                if (target > nums[mid] && target <= nums[finish]) {
                    start = mid + 1;
                } else{
                    finish = mid;
                }
            } else {
                if (target >= nums[start] && target <= nums[mid]) {
                    finish = mid;
                } else {
                    start = mid + 1;
                }
            }
        }
        return (nums[start] == target) ? start: -1;
    }
}
