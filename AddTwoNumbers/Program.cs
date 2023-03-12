using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddTwoNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
          //This Codes Are For Tests


            Random random = new Random();

            Node node = new Node(random.Next(1,10));
            
            Node node2 = new Node (random.Next(1,10) , node);
           
            Node node3 = new Node(random.Next(1,10), node2);
            Console.Write(node3._value + " ");
            Console.Write(node2._value + " ");
            Console.Write(node._value + " ");

            Console.WriteLine();

            Node node4 = new Node(random.Next(1,10));
            
            Node node5 = new Node(random.Next(1,10), node4);
            
            Node node6 = new Node(random.Next(1,10), node5);
            Console.Write(node6._value + " ");
            Console.Write(node5._value + " ");
            Console.Write(node4._value + " ");

            Node newNode = AddTwoNumbersProblem.answer(node3, node6);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            while (newNode != null)
            {
                Console.Write(newNode._value + " ");
                newNode = newNode._next;
            }

            Console.ReadLine();
        }
    }
}
