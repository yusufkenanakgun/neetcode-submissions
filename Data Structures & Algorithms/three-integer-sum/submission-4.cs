public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
        List<List<int>> list = new();
        

        for (int i = 0 ; i < nums.Length - 2 ; i++) {
            if (i > 0 && nums[i] == nums[i - 1]) continue;

            int a = i + 1;
            int b = nums.Length - 1;
            while ( a < b ) {
                if ( nums[a] + nums[b] + nums[i] > 0){
                    b--;
                } else if ( nums[a] + nums[b] + nums[i] < 0){
                    a++;
                }else {
                    list.Add([nums[a] , nums[b] , nums[i]]);
                    a++;
                    b--;
                    while (a < b && nums[a] == nums[a - 1]) a++; 
                    while (a < b && nums[b] == nums[b + 1]) b--;
                }
            }
        }

    return list; 
    }
}
