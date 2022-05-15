package com.smarthome.entity;

import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;
import org.springframework.stereotype.Component;

import java.util.List;

@Component
@NoArgsConstructor
@AllArgsConstructor
@Data
public class KeyFrame {
    private List<Object> keyFrames;

    public List<Object> getKeyFrames() {
        return keyFrames;
    }

    public void setKeyFrames(List<Object> keyFrames) {
        this.keyFrames = keyFrames;
    }

//    public KeyFrame() {
//    }
//
//    public KeyFrame(List<Object> keyFrames) {
//        this.keyFrames = keyFrames;
//    }

    @Override
    public String toString() {
        return "KeyFrame{" +
                "keyFrames=" + keyFrames +
                '}';
    }
}
