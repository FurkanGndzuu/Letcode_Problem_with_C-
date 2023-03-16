using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kth_Smallest_Element_in_a_BST
{
    public static class Solution
    {
        public static int result(TreeNode root , int k)
        {
            IList<int> list = new List<int>();
            list = InorderTraversal(root, list);
            int smallest = 0;
            if (list.Count > k && list != null)
                smallest = list.ElementAtOrDefault(k-1);
            return smallest;
        }

        private static IList<int> InorderTraversal(TreeNode root , IList<int> list)
        {
            if(root.left != null)
                InorderTraversal(root.left, list);

            list.Add(root.value);

            if(root.right != null)
                InorderTraversal(root.right, list);   

            return list;
        }
    }
}
