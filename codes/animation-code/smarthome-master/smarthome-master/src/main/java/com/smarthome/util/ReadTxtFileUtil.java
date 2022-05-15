package com.smarthome.util;

import java.io.*;


public class ReadTxtFileUtil {
    /**
     * 字节流方式 读取所有txt文本内容
     * @param filePath
     * @return String
     */
    public static String getAllTxt(String filePath) {
        File file = new File(filePath);
        Long fileLengthLong = file.length();
        byte[] fileContent = new byte[fileLengthLong.intValue()];
        FileInputStream fileInputStream = null;
        try {
            fileInputStream = new FileInputStream(file);
            fileInputStream.read(fileContent);
        } catch (FileNotFoundException e) {
            e.printStackTrace();
        } catch (IOException e) {
            e.printStackTrace();
        } finally {
            try {
                fileInputStream.close();
            } catch (IOException e) {
                e.printStackTrace();
            }
        }
        return new String(fileContent);
    }

}
