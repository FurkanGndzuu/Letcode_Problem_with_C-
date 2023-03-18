import java.util.ArrayList;
import java.util.List;

public class Solution {
    public static List<Integer> preorderTraversal(TreeNode root) {
        List<Integer> list = new ArrayList<>();
        if(root != null)
            TraversalAndAddList(root , list);
        return list;
    }

    private static void TraversalAndAddList(TreeNode root ,List<Integer> list){
        list.add(root.val);
        if(root.left !=null)
            TraversalAndAddList(root.left , list);
        if(root.right != null)
            TraversalAndAddList(root.right , list);
    }
}
