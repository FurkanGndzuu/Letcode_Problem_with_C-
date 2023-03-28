public class Main {
    public static void main(String[] args) {
        TreeNode node = new TreeNode(7);
        TreeNode node1 = new TreeNode(15);
        TreeNode node2= new TreeNode(20,node1, node);
        TreeNode node3= new TreeNode(9);
        TreeNode node4= new TreeNode(3,node3 , node2);
        //Solution.levelOrder(node4);

        TreeNode root = new TreeNode(1);
        Solution.levelOrder(null);
    }
}