import java.lang.reflect.Array;
import java.util.*;

public class Solution {
    public static String result(String s){
       String[] words = s.split(" ");
        Collections.reverse(Arrays.asList(words));
     String newText = "";

        for (String word: words) {
            newText += word + " ";
        }
        return newText;
    }
}
