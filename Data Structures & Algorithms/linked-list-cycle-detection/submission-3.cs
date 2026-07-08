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
    public bool HasCycle(ListNode head) {
        ListNode list1 = head;
        ListNode list2 = head;
        if (list1 == null || list1.next == null) {
            return false;
        }

        while (list2 != null ){
            list1 = list1.next;
            list2 = list2.next;
            if (list2 != null){
                list2 = list2.next;
            }
            if (list1 == list2) {
                return true;
            }
        }
        return false;
    }
}
