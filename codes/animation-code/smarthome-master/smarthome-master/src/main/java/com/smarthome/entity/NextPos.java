package com.smarthome.entity;

import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;
import org.springframework.stereotype.Component;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

@Component
@NoArgsConstructor
@AllArgsConstructor
@Data
public class NextPos {
    //行为2move,行为0出现++
    private Integer action = 2;
    //种类
    private Integer type = 4;
    //名称
    private String name = "position";
    //出现时间++
    private double timestamp = 0;
    //起始位置
    private List<Double> startpos = new ArrayList<>(Arrays.asList(44.0, 3.5, 21.3));
    private List<Double> endpos = new ArrayList<>(Arrays.asList(44.0, 3.5, 21.3));
    //旋转角度
    private List<Double> startrotation = new ArrayList<>(Arrays.asList(0.0, 0.0, 0.0));
    private List<Double> endrotation = new ArrayList<>(Arrays.asList(0.0, 0.0, 0.0));
    //大小
    private List<Integer> startscale = new ArrayList<>(Arrays.asList(0, 0, 0));
    private List<Integer> endscale = new ArrayList<>(Arrays.asList(0, 0, 0));
    //持续时间
    private float duration = 0;
    //动画
    private String animation = "";
    //循环时间
    private Integer loop = 0;

    public NextPos(String name, double timestamp, List<Double> startpos, List<Double> endpos) {
        this.name = name;
        this.timestamp = timestamp;
        this.startpos = startpos;
        this.endpos = endpos;
    }


    public NextPos(Integer action, String name, double timestamp) {
        this.action = action;
        this.name = name;
        this.timestamp = timestamp;
    }
}
