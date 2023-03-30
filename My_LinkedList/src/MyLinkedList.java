public class MyLinkedList {

    Node head;
    Node tail;
    int size;

  
    public MyLinkedList() {
        size = 0;
        head = null;
        tail = null;
    }

    private Node getNode(int index) {
        Node current = head;
        for (int i = 0; i < index; ++i) current = current.next;
        return current;
    }

     public int get(int index) {
        if (index < 0 || index >= size)
            return -1;
        return getNode(index).val;
    }

    public void addAtHead(int val) {
        Node node = new Node(val, null);
        if (size == 0) head = tail = node;
        else {
            node.next = head;
            head = node;
        }
        ++size;
    }


    public void addAtTail(int val) {
        Node node = new Node(val , null);
        if (size == 0) head = tail = node;
        else {
            tail.next = node;
            tail = node;
        }
        ++size;
    }
 public void addAtIndex(int index, int val) {
        if (index < 0 || index > size)
            return;
        if (index == 0)
            addAtHead(val);
        else if (index == size)
            addAtTail(val);
        else {
            Node current = getNode(index - 1);
            Node node = new Node(val, current.next);
            current.next = node;
            ++size;
        }
    }

    public void deleteAtIndex(int index) {
        if (index < 0 || index >= size)
            return;
        if (size == 1) {
            head = tail = null;
        }
        else if (index == 0) {
            head = head.next;
        }
        else {
            Node current = getNode(index - 1);
            current.next = current.next.next;
            if (index == size-1) tail = current;
        }
        --size;
    }


    public void printLinkedList(){
        Node current = head;
        while(current.next != null){
            System.out.println(current.val);
            current = current.next;
        }
    }
}

class Node{
    int val ;
    Node next;

    public Node(int val , Node next ){
        this.next = next;
        this.val = val;

    }
}

/*
  if(index > size)
            return -1;
        else if (index == 0)
            return head.val;
        else if (index == size )
            return  tail.val;
        else{
            Node current = head;
            while(current.next != null && index > 0){
                current = current.next;
                index--;
            }
             return current.val;
        }



          if(index > this.size)
            return;
        else if (index == 0) {
            head = head.next;
        }
        else{
            Node current = head;
            while(current.next.next != null && index >1){
                current = current.next;
                index--;
            }
            current.next = current.next.next;
            this.size--;
        }
* */
