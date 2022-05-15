package com.smarthome.util;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

public class StringProcessUtil {
    public static String[] processStr(String str){
        String[] s = new String[str.length()];
        s = str.split("\n");
        return s;
    }
    public static String[] processStrBySpace(String str){
        String[] s = new String[str.length()];
        s = str.split(" ");
        return s;
    }
    //获取括号（）里的内容
    public static List<Float> getCircleInStr(String gSQL){
        Float left =Float.parseFloat(gSQL.substring(gSQL.indexOf("(")+1,gSQL.indexOf(",")));
        Float right =Float.parseFloat(gSQL.substring(gSQL.indexOf(",")+1,gSQL.indexOf(")")));
        return Arrays.asList(left,right);
    }
}

