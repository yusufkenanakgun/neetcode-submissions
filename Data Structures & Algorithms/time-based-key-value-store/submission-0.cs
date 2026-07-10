public class TimeMap {
    Dictionary<string, List<(int timestamp, string value)>> map = new();

    public TimeMap() {
        
    }
    
    public void Set(string key, string value, int timestamp) {
        if (map.ContainsKey(key)) {
            map[key].Add((timestamp, value));
        } else {
            map.Add(key,new List<(int, string)>{(timestamp, value)});
        }
        
    }
    
    public string Get(string key, int timestamp) {
        if (!map.ContainsKey(key)) return "";
        var list = map[key];
        int lo = 0, hi = list.Count - 1;
        string res = "";
        while (lo <= hi) {
            int mid = (lo + hi) / 2;
            if (list[mid].timestamp <= timestamp) {
                res = list[mid].value;
                lo = mid + 1;
            } else {
                hi = mid - 1;
            }
        }
        return res;

    }
}
