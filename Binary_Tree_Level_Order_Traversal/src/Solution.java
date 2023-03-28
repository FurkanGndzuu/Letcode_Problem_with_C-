import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

public class Solution {

    public static List<List<Integer>> levelOrder(TreeNode root) {
        List<List<Integer>> list = new ArrayList<>();
        HashMap<Integer , List<Integer>> hash = new HashMap<>();
        addListAccordingToLevel(root , 0 , hash );
        hashToList(list , hash);
        return list;
    }

    private static void addListAccordingToLevel(TreeNode root , int level , HashMap<Integer , List<Integer>> hash){
        if(root == null)
            return;
        if(hash.containsKey(level))
            hash.get(level).add(root.val);
        else {
            hash.put(level , new ArrayList<>());
            hash.get(level).add(root.val);
        }

        if(root.left != null)
            addListAccordingToLevel(root.left , level +1 , hash) ;
        if(root.right != null)
            addListAccordingToLevel(root.right , level +1 , hash) ;
    }

    private  static  void  hashToList(List<List<Integer>> list , HashMap<Integer , List<Integer>> hash){
       if(hash.size() > 0)
           for(Map.Entry<Integer , List<Integer>> a : hash.entrySet()){
                list.add(a.getValue());
           }
    }
}
