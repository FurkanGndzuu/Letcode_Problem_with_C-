using Kth_Smallest_Element_in_a_BST;

internal class Program
{
    private static void Main(string[] args)
    {
        //This codes for test

        Random random = new Random();
        TreeNode root = new TreeNode(random.Next(1, 15));
        TreeNode current = root;

        for (int i = 0; i < 12; i++)
        {
            AddBinarySearchTree(current, random.Next(1, 50));
        }

        int result = Solution.result(root, random.Next(1, 10));

        Console.WriteLine(result);
        Console.ReadLine();
    }

    private static TreeNode AddBinarySearchTree(TreeNode root , int data)
    {
        if (root != null)
        {
            if (data < root.value)
                root.left = AddBinarySearchTree(root.left, data);
            else
                root.right = AddBinarySearchTree(root.right, data);
        }
        else
            root = new TreeNode(data);

        return root;

       
    }
}