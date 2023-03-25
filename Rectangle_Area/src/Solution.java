public class Solution {
    public static int computeArea(int ax1, int ay1, int ax2, int ay2, int bx1, int by1, int bx2, int by2) {

        int height = Math.min(ay2 , by2) - Math.max(ay1 , by1);
        int width = Math.min(ax2,bx2) - Math.max(ax1,bx1);
        int fellowArea =0;
        if(height> 0 && width > 0){
             fellowArea = height * width;
        }


        int AreaRectangleA = (ax2 - ax1) * (ay2 - ay1);
        int AreaRectangleB = (bx2 - bx1) * (by2 - by1);

        return AreaRectangleA + AreaRectangleB - fellowArea;


    }
}
