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
        List<Integer> list = new ArrayList<>();
        TraversalAndAdd(root , list);
        for (var item:list
             ) {
            System.out.print(item + " => ");
        }
        System.out.println();
      root = Solution.result(root);
        List<Integer> list2 = new ArrayList<>();
        TraversalAndAdd(root , list2);
        for (var item:list2
        ) {
            System.out.print(item + " => ");
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

    private static void TraversalAndAdd(TreeNode root , List<Integer> list)
    {
        if (root.left != null)
            TraversalAndAdd(root.left , list);

        list.add(root.val);

        if (root.right != null)
            TraversalAndAdd(root.right , list);
    }
}