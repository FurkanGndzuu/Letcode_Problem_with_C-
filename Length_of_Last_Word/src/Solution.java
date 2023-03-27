import java.util.ArrayList;
import java.util.List;

public class Solution {
    public static int lengthOfLastWord(String s) {

        String[] words = s.split(" ");
        List<String> list = new ArrayList<>();
        for (String word:words) {
            if(!word.isEmpty())
                list.add(word);
        }
        return list.get(list.size()-1).length();
    }
}
