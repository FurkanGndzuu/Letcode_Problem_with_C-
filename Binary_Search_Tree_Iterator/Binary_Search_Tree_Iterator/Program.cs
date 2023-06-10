using Binary_Search_Tree_Iterator;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        TreeNode node3 = new TreeNode(3);
        TreeNode node1 = new TreeNode(9);
        TreeNode node2 = new TreeNode(20);
        TreeNode treeNode = new TreeNode(15 , node1 , node2);
        TreeNode root = new TreeNode(7 , node3 , treeNode);

        BSTIterator bst = new BSTIterator(root);
        Console.WriteLine(bst.Next());
        Console.WriteLine(bst.Next());
        Console.WriteLine(bst.HasNext());
        Console.WriteLine(bst.Next());
        Console.WriteLine(bst.HasNext());
        Console.WriteLine(bst.Next());
        Console.WriteLine(bst.HasNext());
        Console.WriteLine(bst.Next());
        Console.WriteLine(bst.HasNext());
       
    }
}