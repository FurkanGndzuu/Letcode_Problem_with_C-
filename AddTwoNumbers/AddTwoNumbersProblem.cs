using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddTwoNumbers
{
    public static class AddTwoNumbersProblem
    {
        public static Node answer(Node n1 , Node n2)
        {
            Stack<Node> stackForList1 = new Stack<Node>();
            Stack<Node> stackForList2 = new Stack<Node>();


            Node n3 = n1;
            Node n4 = n2;

           while(n3 != null && n4 != null)
            {
                if(n3 != null)
                {
                    stackForList1.Push(n3);
                    n3 = n3._next;
                }
                if (n4 != null)
                {
                    stackForList2.Push(n4);
                    n4 = n4._next;
                }
            }
            string a = "", b = "";

           while(stackForList1.Count != 0 && stackForList2.Count != 0)
            {
                if(stackForList1.Count != 0)
                {
                    a += stackForList1.Pop()._value;
                }
                if(stackForList2.Count != 0)
                {
                    b += stackForList2.Pop()._value;
                }
            }
          

            int c = Convert.ToInt32(a);
            int d = Convert.ToInt32(b);
            int e = c + d;
            
             string f = e.ToString();

            Node[] nodeArray = new Node[f.Length];


            for(int v =0;v<f.Length; v++)
            {
                    
                nodeArray[v] = new Node(Convert.ToInt32(f.Substring(v, 1)));
            }


            for(int i = nodeArray.Length - 1; i> 0; i--)
            {
                nodeArray[i]._next = nodeArray[i - 1];
            }

            return nodeArray[nodeArray.Length - 1];

        }
    }
}
