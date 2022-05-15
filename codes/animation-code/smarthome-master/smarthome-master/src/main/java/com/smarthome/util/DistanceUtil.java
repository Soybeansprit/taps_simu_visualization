package com.smarthome.util;

public class DistanceUtil {
    //引用awt包下的Point类，此类的功能是表示 (x,y) 坐标空间中的位置的点
    public static double getDistance(double x1,double y1,double x2,double y2) {
            Point p1 = new Point(x1, y1);// 定义第一个点的坐标
            Point p2 = new Point(x2, y2);// 定义第二个点的坐标
            //定位坐标
           // System.out.println("p1的x坐标为"+p1.getX());
           // System.out.println("p1的y坐标为"+p1.getY());
           // System.out.println("p2的x坐标为"+p2.getX());
           // System.out.println("p2的y坐标为"+p2.getY());
            // 计算两点间距离公式
            return Math.sqrt(Math.abs((p1.getX() - p2.getX())* (p1.getX() - p2.getX())+(p1.getY() - p2.getY())* (p1.getY() - p2.getY())));
    }
    // 根据速度计算时间，提前移动
    public static double getMovingTime(double distance, double speed){
        // 路程除以速度
        return distance/speed;
    }

}
