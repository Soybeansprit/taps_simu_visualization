using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetAir : MonoBehaviour
{
    private int airmode;
    private InputField input;
    private int temperature;

    public GameObject tmp;
    public GameObject panel;
    private Text text;

    // Start is called before the first frame update
    void Start()
    {
        text = panel.GetComponentInChildren<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {
        airmode = transform.parent.GetComponentInChildren<Dropdown>().value;
        if (airmode == 0)
        {
            SaveGameData.Instance.AirMode = "制冷";
        }
        else
        {
            SaveGameData.Instance.AirMode = "制热";
        }
        input = transform.parent.GetComponentInChildren<InputField>();
        if (!int.TryParse(input.GetComponentInChildren<Text>().text, out temperature))
        {
            text.text = "空调预设温度输入不合法！";
            panel.SetActive(true);
            return;
        }
        if (temperature < 16 || temperature > 32)
        {
            text.text = "空调预设温度输入超出范围！";
            panel.SetActive(true);
            return;
        }
        if (SaveGameData.Instance.AirMode == "制冷" && temperature > SaveGameData.Instance.InitialTemperature)
        {
            text.text = "当前室温小于空调温度时，制冷功能不工作！";
            panel.SetActive(true);
            return;
        }
        else if (SaveGameData.Instance.AirMode == "制热" && temperature < SaveGameData.Instance.InitialTemperature)
        {
            text.text = "当前室温大于空调温度时，制热功能不工作！";
            panel.SetActive(true);
            return;
        }
        SaveGameData.Instance.Temperature = temperature;
        GameObject.Find("Floor").GetComponent<AirOn>().enabled = true;
        GameObject.Find("AirMode").GetComponent<ShowAirMode>().enabled = true;
        GameObject.Find("DefaultTemperature").GetComponent<ShowDefaultTemperature>().enabled = true;
        GameObject.Find("Air").GetComponent<ShowTemperature>().enabled = true;
        GameObject.Find("Air1").GetComponent<ShowTemperature>().enabled = true;
    }
}
