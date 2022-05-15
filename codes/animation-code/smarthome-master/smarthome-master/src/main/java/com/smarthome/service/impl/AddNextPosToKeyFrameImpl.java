package com.smarthome.service.impl;

import com.smarthome.entity.KeyFrame;
import com.smarthome.entity.NextPos;
import com.smarthome.entity.TV;
import com.smarthome.service.AddSmartMachineToKeyFrame;
import com.smarthome.util.DistanceUtil;
import com.smarthome.util.ExcelReadUtil;
import com.smarthome.util.StringProcessUtil;
import org.springframework.stereotype.Service;

import java.util.*;

@Service
public class AddNextPosToKeyFrameImpl implements AddSmartMachineToKeyFrame {
    private static  Map<String,Map<String, Map<String,Double[]>>> homeInfo = new HashMap<>();
    @Override
    public List<Object> addToKeyFrame(KeyFrame keyFrame, String[] ans, List<Object> keyframes) throws Exception {
        // 先前的位置，标记位
        Integer preLocation = 0;
        // 移动速度
        double movingSpeed = 9.0;
        for(String s :ans) {
            String name = "";
            List<Double> startpos = new ArrayList<>();
            List<Double> endpos = new ArrayList<>();
            List<Double> preStartPos = new ArrayList<>();
            List<Double> preEndPos = new ArrayList<>();
            // System.out.println(s);
            // 每行的str
            if (s.startsWith("position")) {
                String[] tmpAns = StringProcessUtil.processStrBySpace(s);
                for (String s1 : tmpAns) {
                    //System.out.println(s1);
                    if (s1.startsWith("position")) {
                        // name
                        name = s1.substring(0, s1.length() - 1);
                        // 初始化为position的位置
                        NextPos firstPos = new NextPos(0,name,0);
                        keyframes.add(firstPos);
                    }else if(s1.startsWith("(")) {
                        // 时间
                        Double timestamp = Double.valueOf(StringProcessUtil.getCircleInStr(s1).get(0));
                        Integer location = StringProcessUtil.getCircleInStr(s1).get(1).intValue();
                        // System.out.println(location+":"+preLocation);
                        // 先判断是否需要移动
                        if (preLocation.equals(location)) continue;
                        // 如果需要移动
                        double[] XZ_pos = new double[2];
                        double[] pre_XZ_pos = new double[2];
                        // System.out.println(location+":"+preLocation);
                        getViewPointFromLocation(location,XZ_pos);
                        getViewPointFromLocation(preLocation,pre_XZ_pos);
                        // System.out.println(location+":"+preLocation);
                        // System.out.println("数组："+pre_XZ_pos[0]+" "+pre_XZ_pos[1]+" "+XZ_pos[0]+" "+XZ_pos[1]);
                        // pre的坐标
                        preStartPos = Arrays.asList(pre_XZ_pos[0],new NextPos().getStartpos().get(1),pre_XZ_pos[1]);
                        preEndPos = Arrays.asList(pre_XZ_pos[0],new NextPos().getStartpos().get(1),pre_XZ_pos[1]);
                        // 把xz的坐标，和初始值y拼凑成新的三维坐标
                        startpos = Arrays.asList(XZ_pos[0],new NextPos().getStartpos().get(1),XZ_pos[1]);
                        endpos = Arrays.asList(XZ_pos[0],new NextPos().getStartpos().get(1),XZ_pos[1]);
                        // 计算应提前多少时间从前一个pos到下一个pos（timestamp）
                        double dist = DistanceUtil.getDistance(pre_XZ_pos[0],pre_XZ_pos[1],XZ_pos[0],XZ_pos[1]);
                        // System.out.println("dist:"+dist);
                        Double movingTime = DistanceUtil.getMovingTime(dist,movingSpeed);
                        // System.out.println("time:"+movingTime);
                        // 更新timestamp的时间
                        timestamp = timestamp - movingTime;
                        NextPos nextPos = new NextPos(name,timestamp,startpos,endpos);
                        // 更新preLocation
                        preLocation = location;
                        // 放入keyframes中
                        keyframes.add(nextPos);
                        // System.out.println(timestamp);
                    }
                }
            }
        }
        return keyframes;
    }
    public static void getViewPointFromLocation(Integer location, double[] pos) throws Exception {
        ExcelReadUtil.showExcel(homeInfo);
        switch (location){
            case 0: {
                pos[0] = new NextPos().getStartpos().get(0);
                pos[1] = new NextPos().getStartpos().get(2);
                break;
            }
            case 1:{
                pos[0] = homeInfo.get("lobby").get("viewpoint_1").get("viewpoint_1")[0];
                pos[1] = homeInfo.get("lobby").get("viewpoint_1").get("viewpoint_1")[2];
                // System.out.println("=========="+pos[0]+"=="+pos[1]);
                break;
            }
            case 2:{
                pos[0] = homeInfo.get("bedroom1").get("viewpoint_2").get("viewpoint_2")[0];
                pos[1] = homeInfo.get("bedroom1").get("viewpoint_2").get("viewpoint_2")[2];
                // System.out.println("=========="+homeInfo.get("bedroom1").get("viewpoint").get("viewpoint")[0]+"=="+pos[1]);
                break;
            }
            case 3:{
                pos[0] = homeInfo.get("kitchen").get("viewpoint_3").get("viewpoint_3")[0];
                pos[1] = homeInfo.get("kitchen").get("viewpoint_3").get("viewpoint_3")[2];
                // System.out.println("=========="+homeInfo.get("kitchen").get("viewpoint_3").get("viewpoint_3")[0]+"=="+pos[1]);
                break;
            }
            case 4:{
                pos[0] = homeInfo.get("bathroom").get("viewpoint_4").get("viewpoint_4")[0];
                pos[1] = homeInfo.get("bathroom").get("viewpoint_4").get("viewpoint_4")[2];
                // System.out.println("=========="+homeInfo.get("bathroom").get("viewpoint_4").get("viewpoint_4")[0]+"=="+pos[1]);
                break;
            }
            case 5:{
                pos[0] = homeInfo.get("bedroom2").get("viewpoint_5").get("viewpoint_5")[0];
                pos[1] = homeInfo.get("bedroom2").get("viewpoint_5").get("viewpoint_5")[2];
                break;
            }
        }
    }
}
