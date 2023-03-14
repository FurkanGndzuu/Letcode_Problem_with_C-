using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeInorderTraversal
{

    public class TreeNode
    {
      public int val;
      public TreeNode left;
      public TreeNode right;
      public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
  }
    public static class Solution
    {
        
        public static IList<int> answer(TreeNode root)
        {
             IList<int> list = new List<int>();
            TraversalAndAdd(root, list);
            return list;

        }

        private static void TraversalAndAdd(TreeNode root , IList<int> list)
        {
            if (root.left != null)
                TraversalAndAdd(root.left , list);

            list.Add(root.val);

            if (root.right != null)
                TraversalAndAdd(root.right , list);
        }
    }

   
}
