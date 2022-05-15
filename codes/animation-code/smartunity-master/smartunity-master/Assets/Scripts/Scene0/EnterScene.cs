using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EnterScene : MonoBehaviour
{
    private GameObject Toggle;
    private GameObject input;
    private GameObject dropdown;
    private GameObject slider;

    private int res;
    public GameObject panel;
    private Text text;

    private void Start()
    {
        text = panel.GetComponentInChildren<Text>();
    }

    public void Click()
    {
        Toggle = GameObject.Find("FirstLightOnToggle");
        SaveGameData.Instance.FirstGroupLightOn = Toggle.GetComponent<Toggle>().isOn;
        if (SaveGameData.Instance.FirstGroupLightOn)
        {
            input = GameObject.Find("FirstLightOnInput");
            if(!int.TryParse(input.GetComponentInChildren<Text>().text, out res)){
                text.text = "未输入第1组灯光打开的等待时间或输入不合法！";
                panel.SetActive(true);
                return;
            }
            SaveGameData.Instance.WaitFirstGroupLightOn = res;
            if (SaveGameData.Instance.WaitFirstGroupLightOn < 0 || SaveGameData.Instance.WaitFirstGroupLightOn > 600)
            {
                text.text = "第1组灯光打开的等待时间输入超出范围！";
                panel.SetActive(true);
                return;
            }
        }

        Toggle = GameObject.Find("SecondLightOnToggle");
        SaveGameData.Instance.SecondGroupLightOn = Toggle.GetComponent<Toggle>().isOn;
        if (SaveGameData.Instance.SecondGroupLightOn)
        {
            input = GameObject.Find("SecondLightOnInput");
            if (!int.TryParse(input.GetComponentInChildren<Text>().text, out res))
            {
                text.text = "未输入第2组灯光打开的等待时间或输入不合法！";
                panel.SetActive(true);
                return;
            }
            SaveGameData.Instance.WaitSecondGroupLightOn = res;
            if (SaveGameData.Instance.WaitSecondGroupLightOn < 0 || SaveGameData.Instance.WaitSecondGroupLightOn > 600)
            {
                text.text = "第2组灯光打开的等待时间输入超出范围！";
                panel.SetActive(true);
                return;
            }
        }

        Toggle = GameObject.Find("ThirdLightOnToggle");
        SaveGameData.Instance.ThirdGroupLightOn = Toggle.GetComponent<Toggle>().isOn;
        if (SaveGameData.Instance.ThirdGroupLightOn)
        {
            input = GameObject.Find("ThirdLightOnInput");
            if (!int.TryParse(input.GetComponentInChildren<Text>().text, out res))
            {
                text.text = "未输入第3组灯光打开的等待时间或输入不合法！";
                panel.SetActive(true);
                return;
            }
            SaveGameData.Instance.WaitThirdGroupLightOn = res;
            if (SaveGameData.Instance.WaitThirdGroupLightOn < 0 || SaveGameData.Instance.WaitThirdGroupLightOn > 600)
            {
                text.text = "第3组灯光打开的等待时间输入超出范围！";
                panel.SetActive(true);
                return;
            }
        }

        Toggle = GameObject.Find("FirstLightOffToggle");
        SaveGameData.Instance.FirstGroupLightOff = Toggle.GetComponent<Toggle>().isOn;
        if (SaveGameData.Instance.FirstGroupLightOff)
        {
            input = GameObject.Find("FirstLightOffInput");
            if (!int.TryParse(input.GetComponentInChildren<Text>().text, out res))
            {
                text.text = "未输入第1组灯光关闭的等待时间或输入不合法！";
                panel.SetActive(true);
                return;
            }
            SaveGameData.Instance.WaitFirstGroupLightOff = res;
            if (SaveGameData.Instance.WaitFirstGroupLightOff < 0 || SaveGameData.Instance.WaitFirstGroupLightOff > 600)
            {
                text.text = "第1组灯光关闭的等待时间输入超出范围！";
                panel.SetActive(true);
                return;
            }
        }

        Toggle = GameObject.Find("SecondLightOffToggle");
        SaveGameData.Instance.SecondGroupLightOff = Toggle.GetComponent<Toggle>().isOn;
        if (SaveGameData.Instance.SecondGroupLightOff)
        {
            input = GameObject.Find("SecondLightOffInput");
            if (!int.TryParse(input.GetComponentInChildren<Text>().text, out res))
            {
                text.text = "未输入第2组灯光关闭的等待时间或输入不合法！";
                panel.SetActive(true);
                return;
            }
            SaveGameData.Instance.WaitSecondGroupLightOff = res;
            if (SaveGameData.Instance.WaitSecondGroupLightOff < 0 || SaveGameData.Instance.WaitSecondGroupLightOff > 600)
            {
                text.text = "第2组灯光关闭的等待时间输入超出范围！";
                panel.SetActive(true);
                return;
            }
        }

        Toggle = GameObject.Find("ThirdLightOffToggle");
        SaveGameData.Instance.ThirdGroupLightOff = Toggle.GetComponent<Toggle>().isOn;
        if (SaveGameData.Instance.ThirdGroupLightOff)
        {
            input = GameObject.Find("ThirdLightOffInput");
            if (!int.TryParse(input.GetComponentInChildren<Text>().text, out res))
            {
                text.text = "未输入第3组灯光关闭的等待时间或输入不合法！";
                panel.SetActive(true);
                return;
            }
            SaveGameData.Instance.WaitThirdGroupLightOff = res;
            if (SaveGameData.Instance.WaitThirdGroupLightOff < 0 || SaveGameData.Instance.WaitThirdGroupLightOff > 600)
            {
                text.text = "第3组灯光关闭的等待时间输入超出范围！";
                panel.SetActive(true);
                return;
            }
        }

        Toggle = GameObject.Find("AirOnToggle");
        SaveGameData.Instance.AirOn = Toggle.GetComponent<Toggle>().isOn;
        if (SaveGameData.Instance.AirOn)
        {
            input = GameObject.Find("AirOnInput");
            if (!int.TryParse(input.GetComponentInChildren<Text>().text, out res))
            {
                text.text = "未输入空调开启的等待时间或输入不合法！";
                panel.SetActive(true);
                return;
            }
            SaveGameData.Instance.WaitAirOn = res;
            if (SaveGameData.Instance.WaitAirOn < 0 || SaveGameData.Instance.WaitAirOn > 600)
            {
                text.text = "空调开启的等待时间输入超出范围！";
                panel.SetActive(true);
                return;
            }
        }

        Toggle = GameObject.Find("AirOffToggle");
        SaveGameData.Instance.AirOff = Toggle.GetComponent<Toggle>().isOn;
        if (SaveGameData.Instance.AirOff)
        {
            input = GameObject.Find("AirOffInput");
            if (!int.TryParse(input.GetComponentInChildren<Text>().text, out res))
            {
                text.text = "未输入空调关闭的等待时间或输入不合法！";
                panel.SetActive(true);
                return;
            }
            SaveGameData.Instance.WaitAirOff = res;
            if (SaveGameData.Instance.WaitAirOff < 0 || SaveGameData.Instance.WaitAirOff > 600)
            {
                text.text = "空调关闭的等待时间输入超出范围！";
                panel.SetActive(true);
                return;
            }
        }

        Toggle = GameObject.Find("CurtainOnToggle");
        SaveGameData.Instance.CurtainOn = Toggle.GetComponent<Toggle>().isOn;
        if (SaveGameData.Instance.CurtainOn)
        {
            input = GameObject.Find("CurtainOnInput");
            if (!int.TryParse(input.GetComponentInChildren<Text>().text, out res))
            {
                text.text = "未输入窗帘打开的等待时间或输入不合法！";
                panel.SetActive(true);
                return;
            }
            SaveGameData.Instance.WaitCurtainOn = res;
            if (SaveGameData.Instance.WaitCurtainOn < 0 || SaveGameData.Instance.WaitCurtainOn > 600)
            {
                text.text = "窗帘打开的等待时间输入超出范围！";
                panel.SetActive(true);
                return;
            }
        }

        Toggle = GameObject.Find("CurtainOffToggle");
        SaveGameData.Instance.CurtainOff = Toggle.GetComponent<Toggle>().isOn;
        if (SaveGameData.Instance.CurtainOff)
        {
            input = GameObject.Find("CurtainOffInput");
            if (!int.TryParse(input.GetComponentInChildren<Text>().text, out res))
            {
                text.text = "未输入窗帘关闭的等待时间或输入不合法！";
                panel.SetActive(true);
                return;
            }
            SaveGameData.Instance.WaitCurtainOff = res;
            if (SaveGameData.Instance.WaitCurtainOff < 0 || SaveGameData.Instance.WaitCurtainOff > 600)
            {
                text.text = "窗帘关闭的等待时间输入超出范围！";
                panel.SetActive(true);
                return;
            }
        }

        Toggle = GameObject.Find("TvOnToggle");
        SaveGameData.Instance.TvOn = Toggle.GetComponent<Toggle>().isOn;
        if (SaveGameData.Instance.TvOn)
        {
            input = GameObject.Find("TvOnInput");
            if (!int.TryParse(input.GetComponentInChildren<Text>().text, out res))
            {
                text.text = "未输入屏幕亮起的等待时间或输入不合法！";
                panel.SetActive(true);
                return;
            }
            SaveGameData.Instance.WaitTvOn = res;
            if (SaveGameData.Instance.WaitTvOn < 0 || SaveGameData.Instance.WaitTvOn > 600)
            {
                text.text = "屏幕亮起的等待时间输入超出范围！";
                panel.SetActive(true);
                return;
            }
        }

        Toggle = GameObject.Find("TvOffToggle");
        SaveGameData.Instance.TvOff = Toggle.GetComponent<Toggle>().isOn;
        if (SaveGameData.Instance.TvOff)
        {
            input = GameObject.Find("TvOffInput");
            if (!int.TryParse(input.GetComponentInChildren<Text>().text, out res))
            {
                text.text = "未输入屏幕熄灭的等待时间或输入不合法！";
                panel.SetActive(true);
                return;
            }
            SaveGameData.Instance.WaitTvOff = res;
            if (SaveGameData.Instance.WaitTvOff < 0 || SaveGameData.Instance.WaitTvOff > 600)
            {
                text.text = "屏幕熄灭的等待时间输入超出范围！";
                panel.SetActive(true);
                return;
            }
        }

        Toggle = GameObject.Find("MicOnToggle");
        SaveGameData.Instance.MicOn = Toggle.GetComponent<Toggle>().isOn;

        Toggle = GameObject.Find("MicOffToggle");
        SaveGameData.Instance.MicOff = Toggle.GetComponent<Toggle>().isOn;

        input = GameObject.Find("InitialTemperature");
        if (!int.TryParse(input.GetComponentInChildren<Text>().text, out res))
        {
            text.text = "未输入预设室温或预设室温输入不合法！";
            panel.SetActive(true);
            return;
        }
        SaveGameData.Instance.InitialTemperature = res;
        if (SaveGameData.Instance.InitialTemperature < -20 || SaveGameData.Instance.InitialTemperature > 40)
        {
            text.text = "预设室温输入超出范围！";
            panel.SetActive(true);
            return;
        }

        if (SaveGameData.Instance.AirOn)
        {
            dropdown = GameObject.Find("AirMode");
            if (dropdown.GetComponent<Dropdown>().value == 0)
            {
                SaveGameData.Instance.AirMode = "制冷";
            }
            else
            {
                SaveGameData.Instance.AirMode = "制热";
            }

            input = GameObject.Find("AirTemperature");
            if (!int.TryParse(input.GetComponentInChildren<Text>().text, out res))
            {
                text.text = "未输入空调预设温度或输入不合法！";
                panel.SetActive(true);
                return;
            }
            SaveGameData.Instance.Temperature = res;
            if (SaveGameData.Instance.Temperature < 16 || SaveGameData.Instance.Temperature > 32)
            {
                text.text = "空调预设温度输入超出范围！";
                panel.SetActive(true);
                return;
            }
            if(SaveGameData.Instance.AirMode == "制冷" && SaveGameData.Instance.Temperature > SaveGameData.Instance.InitialTemperature)
            {
                text.text = "当前室温小于空调温度时，制冷功能不工作！";
                panel.SetActive(true);
                return;
            }
            else if(SaveGameData.Instance.AirMode == "制热" && SaveGameData.Instance.Temperature < SaveGameData.Instance.InitialTemperature)
            {
                text.text = "当前室温大于空调温度时，制热功能不工作！";
                panel.SetActive(true);
                return;
            }
        }

        slider = GameObject.Find("NormalLightIntensity");
        SaveGameData.Instance.NormalLightIntensity = slider.GetComponent<Slider>().value;
        dropdown = GameObject.Find("NormalCurtainState");
        SaveGameData.Instance.NormalCurtainState = (dropdown.GetComponent<Dropdown>().value == 0 ? "打开" : "关闭");

        slider = GameObject.Find("CastLightIntensity");
        SaveGameData.Instance.CastLightIntensity = slider.GetComponent<Slider>().value;
        dropdown = GameObject.Find("CastCurtainState");
        SaveGameData.Instance.CastCurtainState = (dropdown.GetComponent<Dropdown>().value == 0 ? "关闭" : "打开");

        SceneManager.LoadScene("MainScene");
    }
}
