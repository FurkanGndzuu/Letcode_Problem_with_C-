public class ListNode {
    public ListNode next;
    public int value;

    public ListNode(){
    value =0;
    next = null;
    }
    public ListNode(int value){
        this.value = value;
        next = null;
    }
    public ListNode(int value , ListNode next){
        this.value = value;
        this.next = next;
    }
}
