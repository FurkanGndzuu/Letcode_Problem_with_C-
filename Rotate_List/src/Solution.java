public class Solution {
    public static ListNode rotateRight(ListNode head, int k) {
        if(head != null && head.next != null && k != 0){
            int counter = 1;
            ListNode current = head;
            while(current.next != null){
                counter++;
                current = current.next;
            }
            k = k%counter;
          for(int i =0; i<k;i++)
              head = tailtoHead(head);
        }

        return head;
    }
    private static ListNode tailtoHead(ListNode head){
      ListNode  current = head ;
        while(current.next.next != null)
            current = current.next;

        current.next.next = head;
        head = current.next;
        current.next = null;

        return head;
    }
}
