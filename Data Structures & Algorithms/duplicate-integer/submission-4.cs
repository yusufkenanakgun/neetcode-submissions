public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> set = new();
        foreach(int item in nums){
            if (!set.Contains(item)) {
                set.Add(item);
            } else return true;
        }
        return false;
    }
}