using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_Node_in_k_group
{
    public class Node
    {
        public int _value { get; set; }
        public Node _next { get; set; }
        public Node(int value = 0, Node next = null)
        {
            _value = value;
            _next = next;
        }

    
    }
}
