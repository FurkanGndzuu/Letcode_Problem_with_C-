public class Solution {

    public static  TreeNode result(TreeNode root){
        if(root.left == null && root.right == null)
            return root;
        else if (root.left == null && root.right !=null) {
            root.left = root.right;
            root.right =null;
            result(root.left);
        }  else if (root.left != null && root.right ==null) {
            root.right = root.left;
            root.left =null;
            result(root.right);
        }
        else {
            TreeNode rootRight = root.right;
            root.right = root.left;
            root.left =rootRight;
            result(root.left);
            result(root.right);
        }
        return root;
    }
}
