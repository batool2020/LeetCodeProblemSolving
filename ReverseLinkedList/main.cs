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
        // The idea of reversing the linked list is to move through it's nodes using the pointers, starting from the head pointer, copying the pointer to current and moving current through the list.
       ListNode first =null;
       ListNode next = null;
       ListNode current = head;
        // this loop will go through the list node by node, changing the pointers to point reversly on the numbers then assign the head pointer to it's copy current that will be pointing to the end of the linked list
        while(current != null){
            next = current.next;
            current.next = first;
            first = current;
            current = next;
        }
        head = first;
        return head;   
        
    }
}