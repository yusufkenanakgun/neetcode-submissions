public class Solution {
    public void ReorderList(ListNode head) {
        ListNode dummy = new ListNode();
        ListNode temp = new ListNode();
        ListNode tail = dummy;

        ListNode slow = head;
        ListNode fast = head;
        ListNode prevSlow = null;

        while (fast != null) {
            fast = fast.next;
            prevSlow = slow;
            slow = slow.next;
            if (fast != null) {
                fast = fast.next;
            }
        }
        ListNode mid = slow;
        ListNode prev = null;
        ListNode nextt = null;
        while (mid != null){
            nextt = mid.next;
            mid.next = prev;
            prev = mid;
            mid = nextt;
        }
        prevSlow.next = null;

        
        while ( prev != null ) {
            tail.next = head;
            tail = tail.next;
            head = head.next;
            if ( prev != null) {
                tail.next = prev;
                tail = tail.next;
                prev = prev.next;
            }
        }
        if (head != null) {
            tail.next = head;
        }

    }
}
