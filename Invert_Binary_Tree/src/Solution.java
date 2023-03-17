public class Solution {

    public static  TreeNode result(TreeNode root){
        if(root.left == null && root.right == null)
            return root;
        else if (root.left == null && root.right !=null) {
            root.left = root.right;
            root.right =null;
        }  else if (root.left != null && root.right ==null) {
            root.right = root.left;
            root.left =null;
        }
        else {
            TreeNode rootRight = root.right;
            root.right = root.left;
            root.left =rootRight;
        }
        return root;
    }
}
