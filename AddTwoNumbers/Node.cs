using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddTwoNumbers
{
    public class Node
    {
        public int _value { get; set; }
        public Node _next { get; set; }

        public Node(int value)
        {
            _value = value;
            _next = null;
        }
        public Node( int value , Node next )
        {
            _value = value; 
            _next = next;
        }
    }
}
