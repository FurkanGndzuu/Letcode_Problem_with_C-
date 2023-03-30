public class Main {
    public static void main(String[] args) {
        MyLinkedList list = new MyLinkedList();
        list.addAtHead(18);
        list.addAtHead(15);
        list.addAtTail(26);
        list.addAtTail(28);
        list.addAtHead(18);
        list.addAtHead(15);
        list.addAtTail(26);
        list.addAtTail(28);

        //15 18 15 18 26 28 26 28

        System.out.println(list.get(0));

        list.printLinkedList();

        System.out.println();
        System.out.println();
        System.out.println();

        list.addAtIndex(3, 19);
        list.printLinkedList();

        System.out.println();
        System.out.println(list.get(3));

        System.out.println();
        System.out.println();
        System.out.println();

        list.deleteAtIndex(3);
        list.printLinkedList();

        System.out.println();
        System.out.println(list.get(3));


    }
}