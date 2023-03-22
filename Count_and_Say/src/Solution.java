import java.util.HashMap;
import java.util.List;

public class Solution {
    public static String countAndSay(int n) {

        if(n == 1)
            return "1";
        n--;
       String result =  countAndSay(n);
       StringBuilder sb = new StringBuilder();

       for(int i =0;i<result.length();i++){
           int counter = 1;

           while ((i+1) < result.length() && result.charAt(i) == result.charAt(i+1)){
               counter++;
               i++;
           }
            sb.append(counter).append(result.charAt(i));
       }

       String rs = sb.toString();

        return rs;
    }
}
