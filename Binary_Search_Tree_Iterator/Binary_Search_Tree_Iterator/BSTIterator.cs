using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Tree_Iterator
{
    class TreeNode
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
     class BSTIterator
    {

        public TreeNode rootNode { get; set; }
        public TreeNode currentNode  { get; set; }
        public IList<TreeNode> TreeNodes { get; set; }
        public int Counter { get; set; }
        public BSTIterator(TreeNode root)
        {
            rootNode = root;
            currentNode = root;
            Counter = 0;
            TreeNodes = inOrder(root, new List<TreeNode>());
        }

        public int Next()
        {
           if(Counter <= TreeNodes.Count)
            {
                int response = TreeNodes.ElementAtOrDefault(Counter).val;
                Counter++;
                return response;
            }
            throw new Exception();
        }

        public bool HasNext()
        {
            if(Counter + 1 <= TreeNodes.Count)
                return true;
            return false;
        }

        private IList<TreeNode> inOrder (TreeNode root , IList<TreeNode> InOrderNodes)
        {
            if (root.left is not null)
                inOrder(root.left, InOrderNodes);

            if (root is not null)
                InOrderNodes.Add(root);
          
            if (root.right is not null)
                inOrder(root.right, InOrderNodes);

            return InOrderNodes;
        }
    }
}
