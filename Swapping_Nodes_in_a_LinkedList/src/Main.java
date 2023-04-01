public class Main {
    public static void main(String[] args) {
        ListNode node20 = new ListNode(61);
        ListNode node19 = new ListNode(1,node20);
        ListNode node18 = new ListNode(77,node19);
        ListNode node17 = new ListNode(5,node18);
        ListNode node16 = new ListNode(96,node17);
        ListNode node15 = new ListNode(24,node16);
        ListNode node14 = new ListNode(83,node15);
        ListNode node13 = new ListNode(34,node14);
        ListNode node12 = new ListNode(51,node13);
        ListNode node11 = new ListNode(13,node12);
        ListNode node10 = new ListNode(11,node11);
        ListNode node9 = new ListNode(61,node10);
        ListNode node8 = new ListNode(4,node9);
        ListNode node7 = new ListNode(31,node8);
        ListNode node6 = new ListNode(37,node7);
        ListNode node5 = new ListNode(93,node6);
        ListNode node4 = new ListNode(53,node5);
        ListNode node3 = new ListNode(78,node4);
        ListNode node2 = new ListNode(60,node3);
        ListNode node = new ListNode(55,node2);

        ListNode node25 = new ListNode(5);
        ListNode node24 = new ListNode(4 , node25);
        ListNode node23 = new ListNode(3,node24);
        ListNode node22 = new ListNode(2,node23);
        ListNode node21 = new ListNode(1,node22);


        Solution.swapNodes(node21 , 4);
    }
}