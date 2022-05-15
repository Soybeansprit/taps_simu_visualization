package com.smarthome.service.impl;

import com.smarthome.entity.Air;
import com.smarthome.entity.KeyFrame;
import com.smarthome.service.AddSmartMachineToKeyFrame;
import com.smarthome.util.ExcelReadUtil;
import com.smarthome.util.StringProcessUtil;
import org.springframework.stereotype.Service;

import java.util.*;

@Service
public class AddAirToKeyFrameImpl implements AddSmartMachineToKeyFrame {
    private static Map<String,Map<String, Map<String,Double[]>>> homeInfo = new HashMap<>();
    @Override
    public List<Object> addToKeyFrame(KeyFrame keyFrame, String[] ans, List<Object> keyframes) throws Exception {
        ExcelReadUtil.showExcel(homeInfo);
        for(String s :ans){
            String name = new String("");
            List<Double> startpos = new ArrayList<>();
            List<Double> endpos = new ArrayList<>();
            //System.out.println(s);
            //每行的str
            if(s.startsWith("Air")){
                String[] tmpAns = StringProcessUtil.processStrBySpace(s);
                for(String s1:tmpAns){
                    //System.out.println(s1);
                    if(s1.startsWith("Air")){

                        name = s1.substring(0,s1.length()-1);

                    }
                    else if(s1.equals("0")){
                        // 0房间的空调位置
                        startpos = Arrays.asList(homeInfo.get("lobby").get("Air").get("Air")[0], homeInfo.get("lobby").get("Air").get("Air")[1], homeInfo.get("lobby").get("Air").get("Air")[2]);
                        // System.out.println(startpos);
                        endpos = Arrays.asList(homeInfo.get("lobby").get("Air").get("Air")[0], homeInfo.get("lobby").get("Air").get("Air")[1], homeInfo.get("lobby").get("Air").get("Air")[2]);
                        Air air = new Air(0,name,0,startpos,endpos,"AirOff");
                        //放入keyframes中
                        keyframes.add(air);
                        //放入keyframes
                    }
                    // 1房间的位置
                    else if(s1.equals("1")){
                        // 1房间的电视位置
                        startpos = Arrays.asList(-64.0, 5.0, -10.0);
                        endpos = Arrays.asList(-64.0, 5.0, -10.0);
                        Air air = new Air(0,name,0,startpos,endpos,"AirOff");
                        //放入keyframes中
                        keyframes.add(air);
                    }
                    else if(s1.equals("2")){
                        // 1房间的电视位置
                        startpos = Arrays.asList(28.0, 5.0, -15.0);
                        endpos = Arrays.asList(28.0, 5.0, -15.0);
                        Air air = new Air(0,name,0,startpos,endpos,"AirOff");
                        //放入keyframes中
                        keyframes.add(air);
                    }
                    else if(s1.startsWith("(")){
                        //时间
                        float timestamp = StringProcessUtil.getCircleInStr(s1).get(0);
                        //状态（动画）
                        String animation = new String("");
                        switch (StringProcessUtil.getCircleInStr(s1).get(1).intValue()){
                            case 0:
                                animation = "AirOff";
                                break;
                            case 1:
                                animation = "AirCold";
                                break;
                            case 2:
                                animation = "AirHot";
                                break;
                            default:
                                animation = "AirOff";
                                break;
                        }

                        Air air = new Air(name,timestamp,startpos,endpos,animation);
                        //放入keyframes中
                        keyframes.add(air);
                    }
                }
            }

        }
        return keyframes;
    }
}
