package com.smarthome.util;

import org.apache.poi.xssf.usermodel.XSSFRow;
import org.apache.poi.xssf.usermodel.XSSFSheet;
import org.apache.poi.xssf.usermodel.XSSFWorkbook;

import java.io.File;
import java.io.FileInputStream;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

public class ExcelReadUtil {

    private static Map<String,Map<String,Map<String,Double[]>>> m = new HashMap<>();
    public static void main(String[] args) {

        try {
            showExcel(m);
            System.out.println(Double.valueOf(m.get("lobby").get("size").get("size")[0]));
        } catch (Exception e) {
            // TODO Auto-generated catch block
            e.printStackTrace();
        }
    }
    public static void showExcel(Map<String,Map<String,Map<String,Double[]>>> mp) throws Exception {
        XSSFWorkbook workbook=new XSSFWorkbook(new FileInputStream(new File("C:\\Users\\Administrator\\Desktop\\Project\\Grade1\\smarthome\\smarthome_materials\\smartHome.xlsx")));
        XSSFSheet sheet=null;
        Map<String,Double[]> device = new HashMap<>();
        String attr = "";
        Double[] pos = new Double[3];
        Map<String,Map<String,Double[]>> deviceList = new HashMap<>();
        for (int i = 0; i < workbook.getNumberOfSheets(); i++) {//获取每个Sheet表
            sheet=workbook.getSheetAt(i);
            String roomName = sheet.getSheetName();
            //System.out.print(sheet.getSheetName());
            for (int j = 0; j < sheet.getPhysicalNumberOfRows(); j++) {//获取每行
                device = new HashMap<>();
                XSSFRow row=sheet.getRow(j);
                attr = "";
                pos = new Double[3];
                for (int k = 0; k < row.getPhysicalNumberOfCells(); k++) {//获取每个单元格
                    //System.out.print(row.getCell(k)+"\t");
                    if(k == 0) {
                        attr = String.valueOf(row.getCell(0));
                        //System.out.println(attr);
                    }
                    else{
                        pos[k-1] = Double.valueOf(String.valueOf(row.getCell(k)));
                        //System.out.println(pos[k-1]);
                    }
                }
                device.put(attr,new Double[]{pos[0],pos[1],pos[2]});
                // System.out.println(device);
                // System.out.println("---Sheet表"+i+"处理完毕---");\
                deviceList.put(attr,device);
                // System.out.println(mp.get(roomName));
            }
            mp.put(roomName,deviceList);
        }
    }
}
