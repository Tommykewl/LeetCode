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
    public ListNode OddEvenList(ListNode head) {
        if(head == null || head.next == null || head.next.next == null){
            return head;
        }

        var oddHead = head;
        var evenHead = head.next;
        var oddCurr = oddHead;
        var evenCurr = evenHead;

        while(oddCurr.next != null && evenCurr.next != null){
            oddCurr.next = oddCurr.next.next;
            oddCurr = oddCurr.next;
            evenCurr.next = evenCurr.next.next;
            evenCurr = evenCurr.next;
        }

        oddCurr.next = evenHead;

        return oddHead;
    }
}