package com.smarthome.service;



import com.smarthome.entity.KeyFrame;
import org.springframework.stereotype.Service;

import java.util.List;


public interface AddSmartMachineToKeyFrame {
    List<Object> addToKeyFrame(KeyFrame keyFrame, String[] ans, List<Object>keyframes) throws Exception;
}
