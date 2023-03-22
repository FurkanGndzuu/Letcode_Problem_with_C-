class Solution {
    public static boolean isValid(String s) {
        boolean flag = true;
        for(int i=0;i<s.length();i+=2){
            if(s.charAt(i) == '(' && s.charAt(i+1) != ')')
                flag = false;
            else if(s.charAt(i) == '[' && s.charAt(i+1) != ']')
                flag = false;
            else if(s.charAt(i) == '{' && s.charAt(i+1) != '}')
                flag = false;
        }
        return flag;
    }
}
