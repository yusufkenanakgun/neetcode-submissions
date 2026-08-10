/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> neighbors;

    public Node() {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
}
*/

public class Solution {
    

    public Node CloneGraph(Node node) {
        if (node == null) {
            return null;
        }
        Dictionary<Node, Node> map = new();
        Queue <Node> queue = new();
        
        queue.Enqueue(node);

        while (queue.Count != 0 ) {
            Node asd = queue.Dequeue();
            if (!map.ContainsKey(asd)) {
                Node dummy = new Node(asd.val);
                map[asd] = dummy;
                
                
            }
            for (int i = 0; i < asd.neighbors.Count; i++) {
                Node a = asd.neighbors[i];

                if (!map.ContainsKey(a)) {
                    Node tl = new Node(a.val);
                    map[a] = tl;
                    queue.Enqueue(a);
                }
                
                map[asd].neighbors.Add(map[a]);
            }
        }
        return map[node];
        
        
    }

}
