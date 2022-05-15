package com.smarthome.entity;

import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;
import org.springframework.stereotype.Component;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
@Component
@AllArgsConstructor
@NoArgsConstructor
@Data
public class Air {
    //行为2move,行为0出现++
    private Integer action = 2;
    //种类
    private Integer type = 2;
    //名称
    private String name = "Curtain";
    //出现时间++
    private float timestamp = 0;
    //起始位置
    private List<Double> startpos = new ArrayList<>(Arrays.asList(-22.6, 5.0, -5.18));
    private List<Double> endpos = new ArrayList<>(Arrays.asList(-22.6, 5.0, -5.18));
    //旋转角度
    private List<Double> startrotation = new ArrayList<>(Arrays.asList(-90.0, 90.0, 0.0));
    private List<Double> endrotation = new ArrayList<>(Arrays.asList(-90.0, 90.0, 0.0));
    //大小
    private List<Integer> startscale = new ArrayList<>(Arrays.asList(6, 6, 6));
    private List<Integer> endscale = new ArrayList<>(Arrays.asList(6, 6, 6));
    //持续时间
    private float duration = 0;
    //动画
    private String animation = "AirOff";
    //循环时间
    private Integer loop = 0;



    public Air(Integer action, String name, float timestamp, String animation) {
        this.action = action;
        this.name = name;
        this.timestamp = timestamp;
        this.animation = animation;
    }

    public Air(String name, float timestamp, String animation) {
        this.name = name;
        this.timestamp = timestamp;
        this.animation = animation;
    }

    public Air(Integer action, String name, float timestamp, List<Double> startpos, List<Double> endpos, String animation) {
        this.action = action;
        this.name = name;
        this.timestamp = timestamp;
        this.startpos = startpos;
        this.endpos = endpos;
        this.animation = animation;
    }

    public Air(String name, float timestamp, List<Double> startpos, List<Double> endpos, String animation) {
        this.name = name;
        this.timestamp = timestamp;
        this.startpos = startpos;
        this.endpos = endpos;
        this.animation = animation;
    }

    public Integer getAction() {
        return action;
    }

    public void setAction(Integer action) {
        this.action = action;
    }

    public Integer getType() {
        return type;
    }

    public void setType(Integer type) {
        this.type = type;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public float getTimestamp() {
        return timestamp;
    }

    public void setTimestamp(float timestamp) {
        this.timestamp = timestamp;
    }

    public List<Double> getStartpos() {
        return startpos;
    }

    public void setStartpos(List<Double> startpos) {
        this.startpos = startpos;
    }

    public List<Double> getEndpos() {
        return endpos;
    }

    public void setEndpos(List<Double> endpos) {
        this.endpos = endpos;
    }

    public List<Double> getStartrotation() {
        return startrotation;
    }

    public void setStartrotation(List<Double> startrotation) {
        this.startrotation = startrotation;
    }

    public List<Double> getEndrotation() {
        return endrotation;
    }

    public void setEndrotation(List<Double> endrotation) {
        this.endrotation = endrotation;
    }

    public List<Integer> getStartscale() {
        return startscale;
    }

    public void setStartscale(List<Integer> startscale) {
        this.startscale = startscale;
    }

    public List<Integer> getEndscale() {
        return endscale;
    }

    public void setEndscale(List<Integer> endscale) {
        this.endscale = endscale;
    }

    public float getDuration() {
        return duration;
    }

    public void setDuration(float duration) {
        this.duration = duration;
    }

    public String getAnimation() {
        return animation;
    }

    public void setAnimation(String animation) {
        this.animation = animation;
    }

    public Integer getLoop() {
        return loop;
    }

    public void setLoop(Integer loop) {
        this.loop = loop;
    }

    @Override
    public String toString() {
        return "Air{" +
                "action=" + action +
                ", type=" + type +
                ", name='" + name + '\'' +
                ", timestamp=" + timestamp +
                ", startpos=" + startpos +
                ", endpos=" + endpos +
                ", startrotation=" + startrotation +
                ", endrotation=" + endrotation +
                ", startscale=" + startscale +
                ", endscale=" + endscale +
                ", duration=" + duration +
                ", animation='" + animation + '\'' +
                ", loop=" + loop +
                '}';
    }
}
