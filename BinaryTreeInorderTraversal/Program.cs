using BinaryTreeInorderTraversal;

internal class Program
{
    private static void Main(string[] args)
    {
        // This codes for test

        Random random = new Random();
        TreeNode root = new TreeNode(25, null, null);

        for(int i =0; i < 12; i++)
        {
            TestTree(root, random.Next(1, 50));
        }
        List<int> list = (List<int>)Solution.answer(root);

        foreach(var item in list)
        {
            Console.Write(item + " => ");
        }
        Console.ReadLine();
    }

    private static TreeNode TestTree(TreeNode root , int data)
    {
        if(root != null)
        {
            if (data < root.val)
              root.left =  TestTree(root.left, data);
            else
              root.right =  TestTree(root.right, data);
        }
        else
            root = new TreeNode(data);

        return root;
            
    }
}