import java.util.Random;

public class Main {
    public static void main(String[] args) {
        //This codes for Test

        Random random = new Random();
        ListNode head = new ListNode(random.nextInt(1,10));
        System.out.print(head.value + " => ");
        ListNode current = head;
        for(int i =0; i<12 ; i++){
            ListNode newNode = new ListNode(random.nextInt(1,10));
            AddNode(current , newNode);
            System.out.print(newNode.value + " => ");
        }
        int a = random.nextInt(1,10);
        System.out.println("\n" + a);
        ListNode node = Solution.result(head , a);
        System.out.println();
        while(node !=null){
            System.out.print(node.value + " => ");
            node = node.next;
        }

    }

    private static void AddNode(ListNode head , ListNode node){
        if(head.next == null)
            head.next =node;
        else
            AddNode(head.next , node);
    }
}