/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     int val;
 *     ListNode next;
 *     ListNode() {}
 *     ListNode(int val) { this.val = val; }
 *     ListNode(int val, ListNode next) { this.val = val; this.next = next; }
 * }
 */

class Solution {
    public ListNode reverseList(ListNode head) {
        ListNode prev = null;
        ListNode curr = head;
        
        while (curr != null) {
            ListNode next = curr.next;   // 1. ileriyi kaydet
            curr.next = prev;             // 2. oku ters çevir
            prev = curr;                  // 3. prev'i ilerlet
            curr = next;                  // 4. curr'ı ilerlet
        }
        
        return prev;
    }
}