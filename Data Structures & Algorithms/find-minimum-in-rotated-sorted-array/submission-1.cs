public class Solution {
    public int FindMin(int[] nums) {
        int left = 0, right = nums.Length - 1;
        while (left < right) {              // note: <  not <=
            int mid = left + (right - left) / 2;
            if (nums[mid] > nums[right])
                left = mid + 1;            // min is strictly right of mid
            else
                right = mid;               // mid might BE the min → keep it
        }
        return nums[left];                 // left == right → points at the min
    }
}
