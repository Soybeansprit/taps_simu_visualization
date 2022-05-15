package com.smarthome.util;

import com.alibaba.fastjson.JSON;
import com.alibaba.fastjson.JSONObject;

import java.io.*;
import java.util.Collection;
import java.util.List;


public class JsonUtil {
    public static JSONObject putJsonData(Object obj,String filePath) throws IOException {
        File file = new File(filePath);
        JSONObject jsonObject = new JSONObject();
        Writer write = new OutputStreamWriter(new FileOutputStream(file), "UTF-8");
        write.write(JSON.toJSONString(obj));
        // System.out.println(jsonObject.toJSONString(obj));
        write.flush();
        write.close();
        System.out.println("Success!");
        return null;
    }
}
