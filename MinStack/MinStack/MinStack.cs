using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinStack
{
    public class MinStack
    {
        Stack<int> stack;
        public MinStack()
        {
            stack = new Stack<int>();
        }

        public void Push(int val)
        {
            stack.Push(val);
        }

        public void Pop()
        {
            stack.Pop();
        }

        public int Top()
        {
            return stack.Peek();
        }

        public int GetMin() => stack.OrderBy(x => x).FirstOrDefault();
    }
}
