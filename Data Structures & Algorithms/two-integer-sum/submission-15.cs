public class Solution {
     public int[] TwoSum(int[] nums, int target) {
      Dictionary<int,int> map = new();
      for (int i = 0; i < nums.Length; i++) {
          int need = target - nums[i];
          if (map.ContainsKey(need))           // is the partner already seen?
              return new int[] { map[need], i };
          map[nums[i]] = i;                     // not seen → add ME, then move on
      }
      return new int[] {0};
  }
}
