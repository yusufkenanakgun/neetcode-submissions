public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        ListNode dummy = new ListNode(0);
        dummy.next = head;
        ListNode curr = head, prev = null;
        int count = 0;

        while (count != n) {
            count++;
            prev = curr;
            curr = curr.next;
        }
        prev = dummy;
        ListNode temp = head;
        while (curr != null) {
            prev = temp;
            curr = curr.next;
            temp = temp.next;
        }

        ListNode temp2 = temp.next;
        temp.next = null;
        prev.next = temp2;
        
        return dummy.next;
    }
}
