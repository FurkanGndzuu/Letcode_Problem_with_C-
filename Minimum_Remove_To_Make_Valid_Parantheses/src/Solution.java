public class Solution {
    public String minRemoveToMakeValid(String s) {
        StringBuilder stringBuilder = new StringBuilder();
        int counter = 0;
      for(int i = 0; i<s.length() ; i++){

          if(s.charAt(i) == '(')
              counter++;
          else if (s.charAt(i) == ')') {
              if(counter == 0)
                  continue;
              counter--;
          }

          stringBuilder.append(s.charAt(i));
      }

      for(int i = stringBuilder.length() - 1;i>=0 && counter > 0;i--){
          if(stringBuilder.charAt(i) == '('){
              counter--;
              stringBuilder.deleteCharAt(i);
          }
      }
        return stringBuilder.toString();
    }
}
