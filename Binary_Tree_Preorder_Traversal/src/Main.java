import java.util.ArrayList;
import java.util.List;
import java.util.Random;

public class Main {
    public static void main(String[] args) {
        Random random = new Random();
        TreeNode root = new TreeNode(25, null, null);
        for(int i =0; i < 12; i++)
        {
            TestTree(root, random.nextInt(1, 50));
        }

        List<Integer> resultList = Solution.preorderTraversal(root);

        for (int item: resultList) {
            System.out.print(item + " ");
        }

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