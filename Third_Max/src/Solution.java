import java.util.Arrays;
import java.util.Stack;

public class Solution {
    public static int thirdMax(int[] nums) {
        Arrays.sort(nums);
        Stack<Integer> stack = new Stack<>();
        for (int num:nums) {
            if(stack.search(num) == -1)
                stack.add(num);
        }
        if(stack.size() >= 3){
            int thirdMax =0 ;
            for(int i =0;i<3;i++){
                thirdMax = stack.pop();
            }
            return thirdMax;
        }

        else return stack.pop();

    }
}

