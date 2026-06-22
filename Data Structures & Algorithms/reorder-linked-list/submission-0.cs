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
    public void ReorderList(ListNode head) {
        var slow = head;
        var fast = head;

        while (fast.next != null && fast.next.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }

        ListNode prev = null;
        ListNode current = slow.next;
        slow.next = null;

        while (current != null)
        {
            var nextTemp = current.next;
            current.next = prev;
            prev = current;
            current = nextTemp;
        }

        ListNode firstHalf = head;
        ListNode secondHalf = prev;

        while (secondHalf != null) {
            ListNode t1 = firstHalf.next;
            ListNode t2 = secondHalf.next;

            firstHalf.next = secondHalf;
            secondHalf.next = t1;
            
            firstHalf = t1;
            secondHalf = t2;
        }
    }
}
