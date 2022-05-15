package com.smarthome.service.impl;



import com.smarthome.entity.Curtain;
import com.smarthome.entity.KeyFrame;
import com.smarthome.service.AddSmartMachineToKeyFrame;
import com.smarthome.util.ExcelReadUtil;
import com.smarthome.util.StringProcessUtil;
import com.smarthome.util.counter.CounterUtil;
import org.springframework.stereotype.Service;

import java.util.*;

@Service
public class AddCurtainToKeyFrameImpl implements AddSmartMachineToKeyFrame {
    private CounterUtil counter = new CounterUtil();
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
            if(s.startsWith("Curtain")){
                String[] tmpAns = StringProcessUtil.processStrBySpace(s);
                for(String s1:tmpAns){
                    //System.out.println(s1);
                    if(s1.startsWith("Curtain")){

                        name = s1.substring(0,s1.length()-1);

                    }else if(s1.equals("0")){
                        // 0房间的灯位置
                        //判断0房间的窗帘是哪个
                        // System.out.println(counter.getCount().get());
                        // curtain1
                        if(counter.getCount().get() == 0){
                            startpos = Arrays.asList(homeInfo.get("lobby").get("Curtain_1").get("Curtain_1")[0], homeInfo.get("lobby").get("Curtain_1").get("Curtain_1")[1], homeInfo.get("lobby").get("Curtain_1").get("Curtain_1")[2]);
                            endpos = Arrays.asList(homeInfo.get("lobby").get("Curtain_1").get("Curtain_1")[0], homeInfo.get("lobby").get("Curtain_1").get("Curtain_1")[1], homeInfo.get("lobby").get("Curtain_1").get("Curtain_1")[2]);
                            // System.out.println(startpos);
                            Curtain curtain = new Curtain(0,name,0,startpos,endpos,"CloseCurtain");
                            //放入keyframes中
                            keyframes.add(curtain);
                            //计数器加1
                            counter.addCount();
                        }
                        // curtain2
                        else if(counter.getCount().get() == 1){
                            startpos = Arrays.asList(homeInfo.get("lobby").get("Curtain_2").get("Curtain_2")[0], homeInfo.get("lobby").get("Curtain_2").get("Curtain_2")[1], homeInfo.get("lobby").get("Curtain_2").get("Curtain_2")[2]);
                            endpos = Arrays.asList(homeInfo.get("lobby").get("Curtain_2").get("Curtain_2")[0], homeInfo.get("lobby").get("Curtain_2").get("Curtain_2")[1], homeInfo.get("lobby").get("Curtain_2").get("Curtain_2")[2]);
                            // System.out.println(startpos);
                            Curtain curtain = new Curtain(0,name,0,startpos,endpos,"CloseCurtain");
                            //放入keyframes中
                            keyframes.add(curtain);
                            counter.addCount();
                        }
                        //本房间的计数器清零
                    }
                    // curtain_3
                    else if(s1.equals("1")){
                        // 0房间的灯位置
                        //判断0房间的窗帘是哪个
                        // System.out.println(counter.getCount().get());
                        if(counter.getCount().get() == 2){
                            startpos = Arrays.asList(homeInfo.get("bedroom1").get("Curtain_3").get("Curtain_3")[0], homeInfo.get("bedroom1").get("Curtain_3").get("Curtain_3")[1], homeInfo.get("bedroom1").get("Curtain_3").get("Curtain_3")[2]);
                            endpos = Arrays.asList(homeInfo.get("bedroom1").get("Curtain_3").get("Curtain_3")[0], homeInfo.get("bedroom1").get("Curtain_3").get("Curtain_3")[1], homeInfo.get("bedroom1").get("Curtain_3").get("Curtain_3")[2]);
                            // System.out.println(startpos);
                            Curtain curtain = new Curtain(0,name,0,startpos,endpos,"CloseCurtain");
                            //放入keyframes中
                            keyframes.add(curtain);
                            //计数器加1
                            counter.addCount();
                        }
                        //本房间的计数器清零
                    }
                    else if(s1.equals("2")){
                        // 0房间的灯位置
                        //判断0房间的窗帘是哪个
                        // System.out.println(counter.getCount().get());
                        if(counter.getCount().get() == 3){
                            startpos = Arrays.asList(41.7, 11.38, -52.1);
                            endpos = Arrays.asList(41.7, 11.38, -52.1);
                            Curtain curtain = new Curtain(0,name,0,startpos,endpos,"CloseCurtain");
                            //放入keyframes中
                            keyframes.add(curtain);
                            //计数器加1
                            counter.addCount();
                        }
                        //本房间的计数器清零
                    }
                    // 1房间的位置
//                    else if(s1.equals("1")){
//                        // 1房间的灯位置
//                        startpos = Arrays.asList(-35.0, 12.0, -25.0);
//                        endpos = Arrays.asList(-35.0, 12.0, -25.0);
//                        Curtain curtain = new Curtain(0,name,0,startpos,endpos,"Curtain");
//                        //放入keyframes中
//                        keyframes.add(curtain);
//                    }
//                    else if(s1.equals("2")){
//                        // 2房间的灯位置
//                        startpos = Arrays.asList(57.0, 12.0, -20.0);
//                        endpos = Arrays.asList(57.0, 12.0, -20.0);
//                        Curtain curtain = new Curtain(0,name,0,startpos,endpos,"Curtain");
//                        //放入keyframes中
//                        keyframes.add(curtain);
//                    }
                    else if(s1.startsWith("(")){
                        //时间
                        float timestamp = StringProcessUtil.getCircleInStr(s1).get(0);

                        //状态（动画）
                        String animation = new String("");
                        switch (StringProcessUtil.getCircleInStr(s1).get(1).intValue()){
                            case 1:
                                animation = "OpenCurtain";
                                break;
                            default:
                                animation = "CloseCurtain";
                                break;
                        }

                        Curtain curtain = new Curtain(name,timestamp,startpos,endpos,animation);
                        //放入keyframes中
                        keyframes.add(curtain);
                    }
                }
            }

        }
        return keyframes;
    }
}

