/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
 
public class Solution {
    public ListNode ReverseList(ListNode head) {
        ListNode curr = head;
        ListNode prev = null;
        ListNode nextt = null;

        while (curr != null) {
            nextt = curr.next;
            curr.next = prev;
            prev = curr;
            curr = nextt;
        }
        return prev;
    }
}
