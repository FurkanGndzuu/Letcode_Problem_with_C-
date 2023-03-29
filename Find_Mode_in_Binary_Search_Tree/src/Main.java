public class Main {
    public static void main(String[] args) {
        TreeNode node = new TreeNode(3);
        TreeNode node1 = new TreeNode(3);
        TreeNode node2 = new TreeNode(3,node,node1);
        TreeNode node3 = new TreeNode(2,null,node2);
        TreeNode node4 = new TreeNode(2,node3,null);
        TreeNode node5 = new TreeNode(2,node4,null);
        TreeNode node6 = new TreeNode(1,null,node5);
    Solution.findMode(node);

    }
}