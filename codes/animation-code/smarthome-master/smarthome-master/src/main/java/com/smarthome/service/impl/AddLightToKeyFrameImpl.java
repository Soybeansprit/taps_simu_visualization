package com.smarthome.service.impl;



import com.smarthome.entity.KeyFrame;
import com.smarthome.entity.Light;
import com.smarthome.service.AddSmartMachineToKeyFrame;
import com.smarthome.util.ExcelReadUtil;
import com.smarthome.util.StringProcessUtil;
import com.smarthome.util.counter.CounterZero;
import org.springframework.stereotype.Service;

import java.util.*;

@Service
public class AddLightToKeyFrameImpl implements AddSmartMachineToKeyFrame {
    private int count = 0;
    private static Map<String,Map<String, Map<String,Double[]>>> homeInfo = new HashMap<>();
    @Override
    public List<Object> addToKeyFrame(KeyFrame keyFrame, String[] ans, List<Object> keyframes) throws Exception {
        ExcelReadUtil.showExcel(homeInfo);
        CounterZero counter = new CounterZero();
        for(String s :ans){
            String name = new String("");
            List<Double> startpos = new ArrayList<>();
            List<Double> endpos = new ArrayList<>();
            //System.out.println(s);
            //每行的str
            if(s.startsWith("Light")){
                String[] tmpAns = StringProcessUtil.processStrBySpace(s);
                for(String s1:tmpAns){
                    //System.out.println(s1);
                    if(s1.startsWith("Light")){

                        name = s1.substring(0,s1.length()-1);

                    }else if(s1.equals("0")){
                        // 0房间的灯1位置,房间的第0个灯
                        if(counter.getCount().get() == 0){
                            startpos = Arrays.asList(homeInfo.get("lobby").get("Light_1").get("Light_1")[0], homeInfo.get("lobby").get("Light_1").get("Light_1")[1], homeInfo.get("lobby").get("Light_1").get("Light_1")[2]);
                            endpos = Arrays.asList(homeInfo.get("lobby").get("Light_1").get("Light_1")[0], homeInfo.get("lobby").get("Light_1").get("Light_1")[1], homeInfo.get("lobby").get("Light_1").get("Light_1")[2]);
                            Light light = new Light(0,name,0,startpos,endpos,"LightOff");
                            //放入keyframes中
                            keyframes.add(light);
                            // 计数器累加
                            counter.addCount();
                        }
                        // 0房间的灯2位置，房间的第1个灯
                        else if(counter.getCount().get() == 1){
                            startpos = Arrays.asList(homeInfo.get("lobby").get("Light_2").get("Light_2")[0], homeInfo.get("lobby").get("Light_2").get("Light_2")[1], homeInfo.get("lobby").get("Light_2").get("Light_2")[2]);
                            endpos = Arrays.asList(homeInfo.get("lobby").get("Light_2").get("Light_2")[0], homeInfo.get("lobby").get("Light_2").get("Light_2")[1], homeInfo.get("lobby").get("Light_2").get("Light_2")[2]);
                            Light light = new Light(0,name,0,startpos,endpos,"LightOff");
                            //放入keyframes中
                            keyframes.add(light);
                            counter.addCount();
                        }
//                        // 0房间的灯3位置，房间的第2个灯
//                        else if(counter.getCount().get() == 2){
//                            startpos = Arrays.asList(29.0, 12.0, -25.0);
//                            endpos = Arrays.asList(29.0, 12.0, -25.0);
//                            Light light = new Light(0,name,0,startpos,endpos,"LightOn");
//                            //放入keyframes中
//                            keyframes.add(light);
//                            counter.addCount();
//                        }
                    }
                    // 1房间的位置
                    else if(s1.equals("1")){
                        // System.out.println(counter.getCount().get());
                        // 房间的第3个灯
                        if(counter.getCount().get() == 2){
                            // 1房间的灯位置
                            startpos = Arrays.asList(homeInfo.get("bedroom1").get("Light_3").get("Light_3")[0], homeInfo.get("bedroom1").get("Light_3").get("Light_3")[1], homeInfo.get("bedroom1").get("Light_3").get("Light_3")[2]);
                            endpos = Arrays.asList(homeInfo.get("bedroom1").get("Light_3").get("Light_3")[0], homeInfo.get("bedroom1").get("Light_3").get("Light_3")[1], homeInfo.get("bedroom1").get("Light_3").get("Light_3")[2]);
                            Light light = new Light(0,name,0,startpos,endpos,"LightOff");
                            //放入keyframes中
                            keyframes.add(light);
                            counter.addCount();
                        }
                        // 房间的第4个灯
                        else if(counter.getCount().get() == 3){
                            // 1房间的灯位置
                            startpos = Arrays.asList(homeInfo.get("bedroom1").get("Light_4").get("Light_4")[0], homeInfo.get("bedroom1").get("Light_4").get("Light_4")[1], homeInfo.get("bedroom1").get("Light_4").get("Light_4")[2]);
                            endpos = Arrays.asList(homeInfo.get("bedroom1").get("Light_4").get("Light_4")[0], homeInfo.get("bedroom1").get("Light_4").get("Light_4")[1], homeInfo.get("bedroom1").get("Light_4").get("Light_4")[2]);
                            Light light = new Light(0,name,0,startpos,endpos,"LightOff");
                            //放入keyframes中
                            keyframes.add(light);
                            counter.addCount();
                        }
                    }
                    else if(s1.equals("2")){
                        // 2房间的灯位置,第5个灯,bedroom2.light5
                        if(counter.getCount().get() == 4){
                            startpos = Arrays.asList(homeInfo.get("bedroom2").get("Light_5").get("Light_5")[0], homeInfo.get("bedroom2").get("Light_5").get("Light_5")[1], homeInfo.get("bedroom2").get("Light_5").get("Light_5")[2]);
                            endpos = Arrays.asList(homeInfo.get("bedroom2").get("Light_5").get("Light_5")[0], homeInfo.get("bedroom2").get("Light_5").get("Light_5")[1], homeInfo.get("bedroom2").get("Light_5").get("Light_5")[2]);
                            Light light = new Light(0,name,0,startpos,endpos,"LightOff");
                            //放入keyframes中
                            keyframes.add(light);
                            counter.addCount();
                        }
                        // 2房间的灯位置,第6个灯
                        else if(counter.getCount().get() == 5){
                            startpos = Arrays.asList(homeInfo.get("bedroom2").get("Light_6").get("Light_6")[0], homeInfo.get("bedroom2").get("Light_6").get("Light_6")[1], homeInfo.get("bedroom2").get("Light_6").get("Light_6")[2]);
                            endpos = Arrays.asList(homeInfo.get("bedroom2").get("Light_6").get("Light_6")[0], homeInfo.get("bedroom2").get("Light_6").get("Light_6")[1], homeInfo.get("bedroom2").get("Light_6").get("Light_6")[2]);
                            Light light = new Light(0,name,0,startpos,endpos,"LightOff");
                            //放入keyframes中
                            keyframes.add(light);
                            counter.addCount();
                        }

                    }
                    // 卫生间
                    else if(s1.equals("3")){
                        // 3房间的灯位置,第7个灯
                        if(counter.getCount().get() == 6){
                            startpos = Arrays.asList(homeInfo.get("bathroom").get("Light_7").get("Light_7")[0], homeInfo.get("bathroom").get("Light_7").get("Light_7")[1], homeInfo.get("bathroom").get("Light_7").get("Light_7")[2]);
                            endpos = Arrays.asList(homeInfo.get("bathroom").get("Light_7").get("Light_7")[0], homeInfo.get("bathroom").get("Light_7").get("Light_7")[1], homeInfo.get("bathroom").get("Light_7").get("Light_7")[2]);
                            Light light = new Light(0,name,0,startpos,endpos,"LightOff");
                            //放入keyframes中
                            keyframes.add(light);
                            counter.addCount();
                        }
                        // 3房间的灯位置,第8个灯
                        else if(counter.getCount().get() == 7){
                            startpos = Arrays.asList(homeInfo.get("bathroom").get("Light_8").get("Light_8")[0], homeInfo.get("bathroom").get("Light_8").get("Light_8")[1], homeInfo.get("bathroom").get("Light_8").get("Light_8")[2]);
                            endpos =  Arrays.asList(homeInfo.get("bathroom").get("Light_8").get("Light_8")[0], homeInfo.get("bathroom").get("Light_8").get("Light_8")[1], homeInfo.get("bathroom").get("Light_8").get("Light_8")[2]);
                            Light light = new Light(0,name,0,startpos,endpos,"LightOff");
                            //放入keyframes中
                            keyframes.add(light);
                            counter.addCount();
                        }

                    }
                    // 厨房
                    else if(s1.equals("4")){
                        // 3房间的灯位置,第7个灯
                        if(counter.getCount().get() == 8){
                            startpos =  Arrays.asList(homeInfo.get("kitchen").get("Light_9").get("Light_9")[0], homeInfo.get("kitchen").get("Light_9").get("Light_9")[1], homeInfo.get("kitchen").get("Light_9").get("Light_9")[2]);
                            endpos = Arrays.asList(homeInfo.get("kitchen").get("Light_9").get("Light_9")[0], homeInfo.get("kitchen").get("Light_9").get("Light_9")[1], homeInfo.get("kitchen").get("Light_9").get("Light_9")[2]);
                            Light light = new Light(0,name,0,startpos,endpos,"LightOff");
                            //放入keyframes中
                            keyframes.add(light);
                            counter.addCount();
                        }
                        // 3房间的灯位置,第8个灯
                        else if(counter.getCount().get() == 9){
                            startpos = Arrays.asList(homeInfo.get("kitchen").get("Light_10").get("Light_10")[0], homeInfo.get("kitchen").get("Light_10").get("Light_10")[1], homeInfo.get("kitchen").get("Light_10").get("Light_10")[2]);
                            endpos = Arrays.asList(homeInfo.get("kitchen").get("Light_10").get("Light_10")[0], homeInfo.get("kitchen").get("Light_10").get("Light_10")[1], homeInfo.get("kitchen").get("Light_10").get("Light_10")[2]);
                            // System.out.println(startpos);
                            Light light = new Light(0,name,0,startpos,endpos,"LightOff");
                            //放入keyframes中
                            keyframes.add(light);
                            counter.addCount();
                        }

                    }
                    else if(s1.startsWith("(")){
                        //时间
                        float timestamp = StringProcessUtil.getCircleInStr(s1).get(0);
                        //状态（动画）
                        String animation;
                        switch (StringProcessUtil.getCircleInStr(s1).get(1).intValue()){
                            case 1:
                                animation = "LightOn";
                                break;
                            case 0:
                                animation = "LightOff";
                                break;
                            default:
                                animation = "LightOn";
                                break;
                        }

                        Light light = new Light(name,timestamp,startpos,endpos,animation);
                        //放入keyframes中
                        keyframes.add(light);
                    }
                }
            }

        }
        return keyframes;
    }
}
