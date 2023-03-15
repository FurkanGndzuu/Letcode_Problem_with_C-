using RemoveNthFromEnd;

internal class Program
{
    private static void Main(string[] args)
    {
        //This codes for test

        Random random = new Random();

        ListNode head = new(random.Next(1,10));
        Console.Write(head.val + " => ");

        for(int i = 1; i <= 10; i++)
        {
            ListNode newNode = new(random.Next(1,50));
            AddLinkedList(head, newNode);
            Console.Write(newNode.val+ " => ");
        }

      head =  Solution.result(head, random.Next(1, 10));

        Console.WriteLine("\nAfter Removed");

        while(head != null)
        {
            Console.Write(head.val + " => ");
            head = head.next;
        }

        Console.ReadLine();

    }

    public static void AddLinkedList(ListNode head , ListNode newNode)
    {
        ListNode curr = head;

        if(curr.next == null)
        {
            curr.next = newNode;
        }
        else
        {
            while(curr.next != null)
            {
                curr = curr.next;
            }
            curr.next = newNode;
        }
    }
}