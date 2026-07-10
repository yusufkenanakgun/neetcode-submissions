public class LRUCache {
    Dictionary <int, Node> map = new();

    Node head, tail;

    int count = 0, capacity;

    public LRUCache(int capacity) {
        this.capacity = capacity;
        head = new Node(0,0);
        tail = new Node(0,0);
        tail.prev = head;
        head.next = tail; 
    }

    private void Remove(Node node) {
        node.prev.next = node.next;
        node.next.prev = node.prev;
    } 

    private void Insert(Node node) {
        tail.prev.next = node;
        node.prev = tail.prev;
        node.next = tail;
        tail.prev = node;
    }
    
    public int Get(int key) {
        if (this.map.ContainsKey(key)){
            Node temp = map[key];
            Remove(temp);
            Insert(temp);
            return temp.value;
        } else {
            return -1;
        }
    }
    
    public void Put(int key, int value) {
        if (map.ContainsKey(key)) {
            Node temp = map[key];
            temp.value = value;
            Remove(temp);
            Insert(temp);
            return;
        }
        if (count == capacity) {
            Node oldest = head.next;
            Remove(oldest);
            map.Remove(oldest.key);
            count--;
        }
        Node node = new Node(key, value);
        map.Add(key, node);
        Insert(node);
        count++;
    }
}

class Node {
    public int key, value;
    public Node prev, next;

    public Node(int _key, int _value) {
        key = _key;
        value = _value;
        prev = null;
        next = null;

    }


}
