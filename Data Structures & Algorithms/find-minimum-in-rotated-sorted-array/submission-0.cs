public class Solution {
    public int FindMin(int[] nums) {
        int start = 0;
        int finish = nums.Length - 1;
        int minCount = 10000;
        while (start <= finish) {

            int mid = (start + finish) / 2;
            int min = Math.Min(nums[start], nums[mid]);
            min = Math.Min(min, nums[finish]);
            minCount = Math.Min(min, minCount);

            if (nums[mid] > nums[start]) {
                start = mid + 1;   
            } else {
                finish = mid - 1;
            }
        }
        return minCount;
    }
}
