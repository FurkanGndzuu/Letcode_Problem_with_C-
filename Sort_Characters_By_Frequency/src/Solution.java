import java.util.*;

public class Solution {
    public static String frequencySort(String s) {
        String valueString;
        HashMap<Character , Integer> datas = new HashMap<Character, Integer>();
        for(int i=0; i<s.length();i++){
            addQuantity(datas , s.charAt(i));
        }
        List<Map.Entry<Character , Integer>> dataList = new ArrayList<>(datas.entrySet());
        Collections.sort(dataList , (a , b) -> b.getValue().compareTo(a.getValue()));

        StringBuilder stringBuilder = new StringBuilder();

        for(Map.Entry<Character , Integer> a : dataList){
            for(int i =0;i<a.getValue();i++)
                stringBuilder.append(a.getKey());
        }
        valueString = stringBuilder.toString();
        return valueString;
    }

    private static void addQuantity(HashMap<Character , Integer> datas, char value){
        if(datas.containsKey(value)){
            int quantity = datas.get(value);
            quantity++;
            datas.replace(value , quantity);
        }
        else{
            datas.put(value , 1);
        }
    }
}
