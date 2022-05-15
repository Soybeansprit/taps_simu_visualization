package com.smarthome;

import com.smarthome.entity.NextPos;
import com.smarthome.util.DistanceUtil;
import com.smarthome.util.ExcelReadUtil;
import org.junit.jupiter.api.Test;
import org.springframework.boot.test.context.SpringBootTest;

import java.util.HashMap;
import java.util.Map;

@SpringBootTest
class SmarthomeApplicationTests {
    private static final Map<String,Map<String, Map<String,Double[]>>> homeInfo = new HashMap<>();
    @Test
    void contextLoads() throws Exception {
        ExcelReadUtil.showExcel(homeInfo);
        System.out.println(homeInfo.get("bedroom1").get("viewpoint_2").get("viewpoint_2")[0]);
    }

}
