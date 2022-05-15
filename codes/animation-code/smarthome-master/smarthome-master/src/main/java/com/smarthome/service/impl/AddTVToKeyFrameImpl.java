package com.smarthome.service.impl;


import com.smarthome.entity.KeyFrame;
import com.smarthome.entity.TV;
import com.smarthome.service.AddSmartMachineToKeyFrame;
import com.smarthome.util.ExcelReadUtil;
import com.smarthome.util.StringProcessUtil;
import org.springframework.stereotype.Service;

import java.util.*;

@Service
public class AddTVToKeyFrameImpl implements AddSmartMachineToKeyFrame {
    private static Map<String,Map<String, Map<String,Double[]>>> homeInfo = new HashMap<>();
    @Override
    public List<Object> addToKeyFrame(KeyFrame keyframe, String[] ans, List<Object> keyframes) throws Exception {
        ExcelReadUtil.showExcel(homeInfo);
        for(String s :ans){
            String name = new String("");
            List<Double> startpos = new ArrayList<>();
            List<Double> endpos = new ArrayList<>();
            //System.out.println(s);
            //每行的str
            if(s.startsWith("TV")){
                String[] tmpAns = StringProcessUtil.processStrBySpace(s);
                for(String s1:tmpAns){
                    //System.out.println(s1);
                    if(s1.startsWith("TV")){
                        //实例化一个以txt 名字开头的TV
                        name = s1.substring(0,s1.length()-1);
                    }
                    else if(s1.equals("0")){
                        // 0房间的电视位置
                        startpos = Arrays.asList(homeInfo.get("lobby").get("TV").get("TV")[0], homeInfo.get("lobby").get("TV").get("TV")[1], homeInfo.get("lobby").get("TV").get("TV")[2]);
                        endpos = Arrays.asList(homeInfo.get("lobby").get("TV").get("TV")[0], homeInfo.get("lobby").get("TV").get("TV")[1], homeInfo.get("lobby").get("TV").get("TV")[2]);
                        // System.out.println(startpos);
                        TV tv = new TV(0,name,0,startpos,endpos,"TVOFF");
                        //放入keyframes中
                        keyframes.add(tv);
                    }
                    // 1房间的位置
                    else if(s1.equals("1")){
                        // 1房间的电视位置
                        startpos = Arrays.asList(-65.0, 6.0, -40.0);
                        endpos = Arrays.asList(-65.0, 6.0, -40.0);
                        TV tv = new TV(0,name,0,startpos,endpos,"TVOFF");
                        //放入keyframes中
                        keyframes.add(tv);
                    }
                    // 2房间的位置
                    else if(s1.equals("2")){
                        // 1房间的电视位置
                        startpos = Arrays.asList(26.19, 6.0, -35.0);
                        endpos = Arrays.asList(26.19, 6.0, -35.0);
                        TV tv = new TV(0,name,0,startpos,endpos,"TVOFF");
                        //放入keyframes中
                        keyframes.add(tv);
                    }

                    // 处理状态信息
                    else if(s1.startsWith("(")){
                        float timestamp = StringProcessUtil.getCircleInStr(s1).get(0);
                        String animation = new String("");
                        switch (StringProcessUtil.getCircleInStr(s1).get(1).intValue()){
                            case 0:
                                animation = "TVOFF";
                                break;
                            case 1:
                                animation = "TVON";
                                break;
                            default:
                                animation = "TVOFF";
                                break;
                        }

                        TV tv = new TV(name,timestamp,startpos,endpos,animation);
                        //放入keyframes中
                        keyframes.add(tv);
                    }
                }
            }

        }
        return keyframes;
    }
}
