using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kth_Smallest_Element_in_a_BST
{
    public  class TreeNode
    {
        public int value;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int value=0, TreeNode left=null, TreeNode right= null)
        {
            this.value = value;
            this.left = left;
            this.right = right; 
        }
    }
}
