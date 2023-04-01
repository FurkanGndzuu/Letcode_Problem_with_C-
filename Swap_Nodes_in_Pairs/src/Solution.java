public class Solution {
    public static ListNode swapPairs(ListNode head) {
        if(head == null)
            return  null;
        else if (head.next == null)
            return head;
        else{
            ListNode current = head;
            int counter = 0;
            while(current != null){
                counter++;
                current = current.next;
            }
            current = head;
            int coupleCount = counter/2;
            for (int i = 0;i<coupleCount;i++){
                if(i == 0){
                    head = current.next;
                    swapNodes(current , current.next , i);
                    current=head;
                    current=current.next;
                }
                else {
                    swapNodes(current , current.next.next , i);
                    current = current.next.next;
                }

            }
            return head;
        }
    }

    private static void swapNodes(ListNode node1 , ListNode node2 , int i){
            if(i == 0){
                node1.next = node2.next;
                node2.next = node1;
            }else{
                node1.next.next = node2.next;
                node2.next = node1.next;
                node1.next = node2;
            }
    }
}
