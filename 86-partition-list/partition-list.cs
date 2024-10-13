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
    public ListNode Partition(ListNode head, int x) {
        ListNode newHead = new ListNode();
        newHead.next = head;
        var y = newHead;
        var z = y;
        while(z.next != null){
            if(z.next == y){
                z = z.next;
                continue;
            }
            if(z.next.val < x){
                // remove the node
                var temp = z.next;
                z.next = z.next.next;
                // insert the node at start
                temp.next = y.next;
                y.next = temp;
                y = y.next;
            }else{
                z = z.next;
            }
        }

        return newHead.next;
    }
}