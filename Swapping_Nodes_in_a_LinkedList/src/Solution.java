public class Solution {
    public static ListNode swapNodes(ListNode head, int k) {
        if(head == null)
            return null;
        else if (head.next == null)
            return  head;
        else {
            int counter = 0;
            ListNode current = head;
          while(current != null){
              counter++;
              current = current.next;
          }
          current = head;
          int kLast = counter - k+1;
          if(k == kLast)
              return  head;

          if(counter == 2){
           current.next.next = current;
           head = current.next;
           current.next = null;
          } else if ((k ==1 || k == counter) && counter!=2) {
              ListNode node1 = head;
              while(current.next.next != null){
                  current = current.next;
              }
             ListNode node2 = new ListNode();
              node2.val = current.next.val;
              node2.next = head.next;
              head = node2;
              current.next = node1;
              node1.next = null;
          } else if(Math.ceil(counter / 2.0) == k){
             int i=1;
             while(current.next != null && i<k-1){
                 i++;
                 current = current.next;
             }

             ListNode node1 = new ListNode();
             ListNode node2 = new ListNode();
             node1.val = current.next.val;
             node2.val = current.next.next.val;
             node2.next = node1;
             node1.next = current.next.next.next;
             current.next = node2;

         } else if (Math.ceil(counter / 2.0) == k-1  && counter%2 ==0) {

              int i=1;
              while(current.next != null && i<k-2){
                  i++;
                  current = current.next;
              }

              ListNode node1 = new ListNode();
              ListNode node2 = new ListNode();
              node1.val = current.next.val;
              node2.val = current.next.next.val;
              node2.next = node1;
              node1.next = current.next.next.next;
              current.next = node2;

          } else {
             int i = 1;
             if(k > kLast){
                 int temp = k;
                 k = kLast;
                 kLast = temp;
             }
             ListNode beforeTheKLast = null;
             ListNode beforeTheK = null;
             while(current.next != null && i<kLast){
                 if(i == k-1){
                     beforeTheK = current;
                 }
                 if(i == kLast-1){
                     beforeTheKLast = current;
                 }
                 i++;
                 current = current.next;
             }
             ListNode nodeK =new ListNode();
             ListNode nodeKLast = new ListNode();
             nodeKLast.val = beforeTheKLast.next.val;
             nodeK.val = beforeTheK.next.val;
             nodeK.next = beforeTheKLast.next.next;
             nodeKLast.next = beforeTheK.next.next;
             beforeTheK.next = nodeKLast;
             beforeTheKLast.next = nodeK;
         }

        }
        return  head;
    }
}
