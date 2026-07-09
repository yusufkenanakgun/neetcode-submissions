/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
    public Node copyRandomList(Node head) {
        Node dummy = new Node(0);
        Node tail = dummy;
        Node curr = head;
        Dictionary<Node, Node> map = new();

        while ( curr != null ) {
            Node temp = new Node(curr.val);
            tail.next = temp;
            map.Add(curr, tail.next);
            tail = tail.next;
            curr = curr.next;
        }
        curr = head;
        tail = dummy.next;

        while ( curr != null ) {
            if (curr.random != null) {
                tail.random = map[curr.random];
            } else {
                tail.random = null;
            }
            tail = tail.next;
            curr = curr.next;
        }
        return dummy.next;
        
    }
}
