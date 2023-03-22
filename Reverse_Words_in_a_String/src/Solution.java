import java.lang.reflect.Array;
import java.util.*;

public class Solution {
    public static String result(String s){
       String[] words = s.split(" ");
        Collections.reverse(Arrays.asList(words));
        String newText = "";

        for(int i=0;i< words.length;i++){
       if(words[i].equals(" ")|| words[i].isEmpty())
           continue;
       else if (i == words.length-1)
           newText += words[i];
       else {
           if(words[i+1].isEmpty() && i+1 == words.length-1)
               newText += words[i];
           else
               newText += words[i] + " ";
       }
        }

        String[] newTextWords = newText.split(" ");
        newText ="";
        for(int i = 0 ; i< newTextWords.length; i++){
            if(i == newTextWords.length - 1)
                newText += newTextWords[i];
            else newText += newTextWords[i] + " ";
        }
        return newText;
    }
}

