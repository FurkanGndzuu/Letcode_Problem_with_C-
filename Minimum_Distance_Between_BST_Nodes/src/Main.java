public class Main {
    public static void main(String[] args) {

        TreeNode node4 = new TreeNode(3);
        TreeNode node3 = new TreeNode(1);
        TreeNode node2 = new TreeNode(6);
        TreeNode node1 = new TreeNode(2,node3,node4);
        TreeNode root = new TreeNode(4 , node1 ,node2);
        System.out.println(Solution.minDiffInBST(root));


    }
}