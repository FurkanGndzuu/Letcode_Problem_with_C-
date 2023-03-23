public class Main {
    public static void main(String[] args) {
        TreeNode root = new TreeNode(15);
        root.left = new TreeNode(13);
        root.right = new TreeNode(16);
        TreeNode root2 = new TreeNode(15);
        root2.left = new TreeNode(13);
        root2.right = new TreeNode(16);

        System.out.println(Solution.isSameTree(root , root2));

    }
}