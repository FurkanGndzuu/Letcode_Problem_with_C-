using Reverse_Node_in_k_group;

internal class Program
{
    private static void Main(string[] args)
    {
        Node node = new Node(7);
        Node node2 = new Node(6 ,node);
        Node node3 = new Node(5, node2);
        Node node4 = new Node(4, node3);
        Node node5 = new Node(3, node4);
        Node node6 = new Node(2, node5);
        Node node7 = new Node(1, node6);
        Node currentNode = node7;
        while(currentNode != null)
        {
            Console.Write(currentNode._value +" -> ");
            currentNode = currentNode._next;
        }
        Console.WriteLine();

      Node currentNode2 = Solution.answer(node7 , 3);

        while (currentNode2 != null)
        {
            Console.Write(currentNode2._value + " -> ");
            currentNode2 = currentNode2._next;
        }

        Console.ReadLine();

        

    }
}