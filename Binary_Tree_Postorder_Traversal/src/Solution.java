import java.util.ArrayList;
import java.util.List;

public class Solution {
    public static List<Integer> postorderTraversal(TreeNode root) {
        List<Integer> list = new ArrayList<>();
        if(root != null)
            TraversalAndAddList(root , list);
        return list;
    }

    private static void TraversalAndAddList(TreeNode root ,List<Integer> list){

        if(root.left !=null)
            TraversalAndAddList(root.left , list);
        if(root.right != null)
            TraversalAndAddList(root.right , list);
        list.add(root.val);
    }
}
