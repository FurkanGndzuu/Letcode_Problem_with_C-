public class Main {
    public static void main(String[] args) {
        ListNode node = new ListNode(5);
        ListNode node2 = new ListNode(4,node);
        ListNode node3 = new ListNode(3 , node2);
        ListNode node4 = new ListNode(2 , node3);
        ListNode head = new ListNode(1 , node4);

        ListNode current = Solution.rotateRight(head , 2000000002);

        while(current != null){
            System.out.println(current.val);
            current = current.next;
        }

    }
}