public class Main {
    public static void main(String[] args) {
       MyStack stack = new MyStack();
        stack.push(1);
        stack.push(2);
        stack.push(3);
        stack.push(4);
        stack.push(5);

       int size = stack.getStackSize();
       while(size-- > 3){
           System.out.println(stack.pop());
       }
        System.out.println(stack.top());
        System.out.println(stack.empty());



    }
}