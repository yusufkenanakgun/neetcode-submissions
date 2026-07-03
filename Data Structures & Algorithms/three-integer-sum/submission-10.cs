public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
        List<List<int>> list = new();

         for (int i = 0 ; i < nums.Length ; i++){
            if(i>0 && nums[i] == nums[i-1]) continue;
            int left = i + 1;
            int right = nums.Length - 1;

            while (left < right){
                if (nums[left] + nums[right] + nums[i] > 0 || right == i){
                    right--;
                }else if (nums[left] + nums[right] + nums[i] < 0) {
                    left++;
                } else {
                    list.Add(new List<int>(){nums[left] ,  nums[i] , nums[right]});
                    right--;
                    left++;
                    while (left < right && nums[left] == nums[left - 1]) left++;
                    while (left < right && nums[right] == nums[right + 1]) right--;
                }
            }
        }
        return list;
    }
}
