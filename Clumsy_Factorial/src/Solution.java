public class Solution {
    public static int clumsy(int n) {
        return clumsyRecursive(n , 4);
    }

    private static int clumsyRecursive(int n , int i){
        if(n == 0)
            return 1;
        if(i == 0)
            i = 4;
        if (i == 4)
            return n * clumsyRecursive(n-1 , 3);
        else if (i == 3)
            return n / clumsyRecursive(n-1 , 2);
        else if (i == 2)
            return n + clumsyRecursive(n-1 , 1);
        else
            return n - clumsyRecursive(n-1 , 0);
    }
}
