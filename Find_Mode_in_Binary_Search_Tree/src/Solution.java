import java.util.*;

public class Solution {
    public static int[] findMode(TreeNode root) {
        HashMap<Integer , Integer> hashMap = new HashMap<>();
            if(root == null)
                return null;
            Traversal(root , hashMap);
           int[] modes = Modes(hashMap);
            return modes;
    }
    private static void Traversal(TreeNode root , HashMap<Integer , Integer> hashMap){

        if(hashMap.containsKey(root.val))
            hashMap.replace(root.val, hashMap.get(root.val)+1);
        else hashMap.put(root.val, 1);

        if(root.left != null)
            Traversal(root.left , hashMap);
        if (root.right != null)
            Traversal(root.right , hashMap);
    }
    private static int[] Modes(HashMap<Integer , Integer> hashMap){
        int mode = 0;
        List<Integer> list = new ArrayList<>();
        for (Map.Entry<Integer , Integer> a : hashMap.entrySet()){
            if(a.getValue() > mode)
                mode = a.getValue();
        }
        for (Map.Entry<Integer , Integer> a : hashMap.entrySet()){
            if(a.getValue() == mode)
                list.add(a.getKey());
        }
        int[] modes = new int[list.size()];
       for(int i = 0 ; i<list.size();i++)
           modes[i] = list.get(i);
        return modes;
    }
}
