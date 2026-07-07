public class Solution {
    public int Search(int[] nums, int target) {
        
        int start = 0;
        int finish = nums.Length - 1;
        int result = - 1;

        while (start <= finish) {
            int mid = start + (finish - start) / 2;
            if (target < nums[mid]) {
                finish = mid - 1;
            } else if (target > nums[mid]){
                start = mid + 1;
            } else {
                result = mid;
                break;
            }
        }
        return result;
        
    }
}
