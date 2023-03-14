using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_Node_in_k_group
{
    public static class Solution
    {
        public static int t { get; set; } = 1;
        public static Node answer(Node node , int k)
        {
            Node currentNode1 = node;
            Node currentNode2 = node;
            Node currentNode3 = node;
            int i = 0;
            while(currentNode1 != null)
            {
                i++;
                currentNode1 = currentNode1._next;
            }
            int a = i / k;
            int b = 0;
            int j = 1;
            int c = 1;
            Node currentNode4 = null;

            while (b<a)
            {
                if(c == 1)
                {
                    int f = 1;
                    while(currentNode2 != null && f<k)
                    {
                        currentNode2 = currentNode2._next;
                        f++;
                    }

                    Swap(currentNode3, currentNode2);
                     currentNode4 = currentNode2;
                    c++;
                }
                else
                { int l = j;
                    int h = j + k;
                    while(currentNode3 != null && currentNode2 != null && h>l)
                    {
                        currentNode2 = currentNode2._next;
                        currentNode3 = currentNode3._next;

                        l++;

                        if (l%k == 0)
                        {
                            Swap(currentNode2, currentNode3._next);
                        }

                        
                    }
                }
                j += k;
                b++;
            }

            if (currentNode4 != null)
                return currentNode4;
            else return null;
        }

        private static void Swap(Node node1 , Node node2)
        {
        if(t == 1)
            {
                Node TempNode = node1._next;
                node1._next = node2._next;
                TempNode._next = node1;
                node2._next = TempNode;
            }
            else
            {
                Node node = node1._next._next;
                node1._next = node2._next;
                node1 = node2;
                node2._next = node;
                node._next = node1;
            }

            t++;
           
        }

        
    }
}
