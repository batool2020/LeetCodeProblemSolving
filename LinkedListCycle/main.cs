
 // Definition for singly-linked list.
  public class ListNode {
      public int val;
      public ListNode next;

      public ListNode(int x) {
          val = x;
         next = null;

      }
  }
 
public class Solution
{


    public bool HasCycle(ListNode head)
    {
        // Floid's cycle Finding Algorithm
        //creating 2 pointers, moving one of them one time and the other twice in rounds, and comparing their values

        ListNode left = head, right = head;
        while (left != null && right != null
               && right.next != null)
        {
            left = left.next;
            right = right.next.next;
            if (left == right)
            {
                return true;
            }
        }
        return false;

    }
}