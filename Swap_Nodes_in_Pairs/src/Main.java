public class Main {
    public static void main(String[] args) {
        ListNode node8 = new ListNode(5);
        ListNode node7 = new ListNode(2 );
        ListNode node6 = new ListNode(2,node7);
        ListNode node5 = new ListNode(6,node6);
        ListNode node4 = new ListNode(4 ,node5);
        ListNode node3 = new ListNode(3,node4);
        ListNode node2 = new ListNode(5,node3);
        ListNode node = new ListNode(2,node2);
        Solution.swapPairs(node);
    }
}