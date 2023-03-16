public class Solution {

    public static ListNode result(ListNode head , int val){

        if(head==null){
            return null;
        }
        if(head.value==val){
            return result(head.next,val);
        }
        head.next = result(head.next,val);
        return head;
    }

}
