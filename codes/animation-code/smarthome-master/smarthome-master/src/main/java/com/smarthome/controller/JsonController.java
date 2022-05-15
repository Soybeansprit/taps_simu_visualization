package com.smarthome.controller;

import com.alibaba.fastjson.JSON;
import com.smarthome.entity.KeyFrame;
import com.smarthome.service.AddSmartMachineToKeyFrame;
import com.smarthome.service.impl.*;
import com.smarthome.util.JsonUtil;
import com.smarthome.util.ReadTxtFileUtil;
import com.smarthome.util.StringProcessUtil;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import java.io.IOException;
import java.util.ArrayList;
import java.util.List;

@RestController
@RequestMapping
public class JsonController {

    @Autowired
    private AddTVToKeyFrameImpl addTVToKeyFrame;

    @GetMapping("jsonfile")
    public String getJson() throws Exception {
        String filepath = "C:\\Users\\Administrator\\Desktop\\Project\\Grade1\\smarthome\\newsmarthome210826\\smarthome\\src\\main\\resources\\static\\source.txt";
        // keyframe根节点
        KeyFrame keyFrame = new KeyFrame();
        List<Object> keyFrames = new ArrayList<>();
        // 读入txt文件
        String txtString = ReadTxtFileUtil.getAllTxt(filepath);
        // 把读入的文件，放在字符串数组里
        String[] ans = StringProcessUtil.processStr(txtString);
        // 判读是否有TV加入
        AddSmartMachineToKeyFrame addTV = new AddTVToKeyFrameImpl();
        keyFrames = addTV.addToKeyFrame(keyFrame,ans,keyFrames);
        // 判读是否有Curtain加入
        AddSmartMachineToKeyFrame addCurtain = new AddCurtainToKeyFrameImpl();
        keyFrames = addCurtain.addToKeyFrame(keyFrame,ans,keyFrames);
        // 判断是否有air加入
        AddSmartMachineToKeyFrame addAir = new AddAirToKeyFrameImpl();
        keyFrames = addAir.addToKeyFrame(keyFrame,ans,keyFrames);
        // 判断是否有Light加入
        AddSmartMachineToKeyFrame addLight = new AddLightToKeyFrameImpl();
        keyFrames = addLight.addToKeyFrame(keyFrame,ans,keyFrames);
        // 判断是否有pos加入
        AddSmartMachineToKeyFrame addPos = new AddNextPosToKeyFrameImpl();
        keyFrames = addPos.addToKeyFrame(keyFrame,ans,keyFrames);
        keyFrame.setKeyFrames(keyFrames);
        // 输出json文件
        JsonUtil.putJsonData(keyFrame,"C:\\Users\\Administrator\\Desktop\\Project\\Grade1\\smarthome\\newsmarthome210826\\smarthome\\src\\main\\resources\\static\\keyFrames.json");
        return "src/main/resources/static/keyFrames.json";
    }
    }

