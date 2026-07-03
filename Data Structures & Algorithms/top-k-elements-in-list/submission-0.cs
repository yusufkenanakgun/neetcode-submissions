public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int , int> map = new();
        List<int> list = new();

        foreach (int item in nums) {
            if (!map.ContainsKey(item)) {
                map.Add(item , 1);
            }else {
                map[item]++;
            }
        }
        var sorted = map.OrderByDescending(pair => pair.Value);
        int count = 0;
        foreach ( var pair in sorted){
            if (count == k) break;
            list.Add(pair.Key);
            count++;
        }
        return list.ToArray();
    }
}
