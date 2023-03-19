import java.util.LinkedList;
import java.util.Queue;

class MyStack {
    Queue<Integer> q1 ;
    Queue<Integer> q2;

    public MyStack() {
        q1 =  new LinkedList<Integer>();
        q2 =  new LinkedList<Integer>();
    }

    public void push(int x) {
        q2.add(x);
        while (!q1.isEmpty())
            q2.add(q1.remove());

        while (!q2.isEmpty())
            q1.add(q2.remove());

    }

    public int pop() {
      return q1.remove();
    }

    public int top() {
    return q1.peek();
    }

    public boolean empty() {
    return q1.isEmpty();
    }

    public int getStackSize(){
        return q1.size();
    }
}
