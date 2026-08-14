public class Solution {
    public bool CanFinish(int numCourses, int[][] prerequisites) {
        Dictionary<int, HashSet<int>> map = new();
        Queue<int> q = new();

        int[] count = new int[numCourses];

        for (int i = 0; i < prerequisites.Length; i++ ) {
            int a = prerequisites[i][0], b = prerequisites[i][1];
            count[a]++;
            if (!map.ContainsKey(b)) {
                map.Add(b, new HashSet<int>() {a});
            } else {
                map[b].Add(a);
            }
        }
        for (int i = 0; i < count.Length; i++ ) {
            if(count[i] == 0) q.Enqueue(i);
        }
        int countDown = numCourses;
        while (q.Count != 0) {
            int curr = q.Dequeue();
            countDown--;
            if (map.ContainsKey(curr)) {
                foreach(int item in map[curr]) {
                    count[item]--;
                    if(count[item] == 0) q.Enqueue(item);
                }
            }    
        }
        return (countDown == 0);
        
    }
}
