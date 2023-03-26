import java.util.ArrayList;
import java.util.Collections;
import java.util.List;

public class Solution {
    public static int minDiffInBST(TreeNode root) {
    List<Integer> list = new ArrayList<>();
    if(root != null)
        inOrderTraversalDescendig(root , list);
        int minDiff = 0;
        if(list.size() >=2)
             minDiff = list.get(0) - list.get(1);
       for(int i=0;i<(list.size()-1);i++){
           if((list.get(i) - list.get(i+1)) <= minDiff)
               minDiff = list.get(i) - list.get(i+1);
       }
       return minDiff;
    }

    private static void inOrderTraversalDescendig(TreeNode root , List<Integer> list){

        if(root.right != null)
            inOrderTraversalDescendig(root.right , list);

        list.add(root.val);

        if(root.left != null)
            inOrderTraversalDescendig(root.left , list);
    }
}
