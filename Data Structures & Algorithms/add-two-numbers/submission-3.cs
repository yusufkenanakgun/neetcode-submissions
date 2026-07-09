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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode dummy = new ListNode(0);
        ListNode tail = dummy;
        int count = 0;
        while ( l1 != null && l2 != null ) {
            int value = l1.val + l2.val + count;

            if (value > 9) {
                count = 1;
            } else {
                count = 0;
            }
            value = value % 10;
            ListNode temp = new ListNode( value);
            tail.next = temp;
            tail = tail.next;
            l1 = l1.next;
            l2 = l2.next;
        }
        if (l1 != null) {
            while(l1 != null) {
                int value = l1.val + count;
                if (value > 9) {
                    count = 1;
                } else {
                    count = 0;
                }
                value = value % 10;

                ListNode temp = new ListNode( value);
                tail.next = temp;
                tail = tail.next;
                l1 = l1.next;
            }
        } else {
            while (l2 != null) {
                int value = l2.val + count;
                if (value > 9) {
                    count = 1;
                } else {
                    count = 0;
                }
                value = value % 10;

                ListNode temp = new ListNode(value);
                tail.next = temp;
                tail = tail.next;
                l2 = l2.next;
            }
        }
        if (count == 1 ){
            ListNode temp = new ListNode(1);
            tail.next = temp;
        }

        return dummy.next;    
    }
}
