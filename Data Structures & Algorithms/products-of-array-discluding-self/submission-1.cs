public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] result = new int[nums.Length];
        
        int[] prefix = new int[nums.Length];
        int left = 1;
        for (int i = 0; i <nums.Length; i++) {
            prefix[i] = left;
            left *= nums[i];
        }

        int right = 1;
        for (int i = nums.Length - 1; i >= 0; i--) {
            prefix[i] *= right;
            right *= nums[i];
        }

        return prefix;
    }
}
