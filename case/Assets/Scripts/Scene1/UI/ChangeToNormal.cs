using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeToNormal : MonoBehaviour
{
    private Light[] lightGroup;
    private Animation ani;
    private Slider[] sliders;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnClick()
    {
        lightGroup = GameObject.Find("LightGroup1").GetComponentsInChildren<Light>();
        for (int i = 0; i < lightGroup.Length; ++i)
        {
            lightGroup[i].intensity = SaveGameData.Instance.NormalLightIntensity;
        }
        SaveGameData.Instance.CurrentFirstLightIntensity = SaveGameData.Instance.NormalLightIntensity;
        lightGroup = GameObject.Find("LightGroup2").GetComponentsInChildren<Light>();
        for (int i = 0; i < lightGroup.Length; ++i)
        {
            lightGroup[i].intensity = SaveGameData.Instance.NormalLightIntensity;
        }
        SaveGameData.Instance.CurrentSecondLightIntensity = SaveGameData.Instance.NormalLightIntensity;
        lightGroup = GameObject.Find("LightGroup3").GetComponentsInChildren<Light>();
        for (int i = 0; i < lightGroup.Length; ++i)
        {
            lightGroup[i].intensity = SaveGameData.Instance.NormalLightIntensity;
        }
        SaveGameData.Instance.CurrentThirdLightIntensity = SaveGameData.Instance.NormalLightIntensity;
        for (int i = 0; i < 4; ++i)
        {
            ani = GameObject.Find("Curtain" + i).GetComponent<Animation>();
            if (SaveGameData.Instance.NormalCurtainState == "关闭" && SaveGameData.Instance.Curtain[i])
            {
                ani["Curtain" + i].time = ani["Curtain" + i].clip.length;
                ani["Curtain" + i].speed = -1.0f;
                ani.Play("Curtain" + i);
                SaveGameData.Instance.Curtain[i] = false;
            }
            else if (SaveGameData.Instance.NormalCurtainState == "打开" && !SaveGameData.Instance.Curtain[i])
            {
                ani["Curtain" + i].speed = 1.0f;
                ani.Play("Curtain" + i);
                SaveGameData.Instance.Curtain[i] = true;
            }
        }
        sliders = GameObject.Find("Settings").GetComponentsInChildren<Slider>();
        sliders[0].gameObject.GetComponent<ChangeFirstLight>().enabled = false;
        sliders[0].gameObject.GetComponent<ChangeFirstLight>().enabled = true;
        sliders[1].gameObject.GetComponent<ChangeSecondLight>().enabled = false;
        sliders[1].gameObject.GetComponent<ChangeSecondLight>().enabled = true;
        sliders[2].gameObject.GetComponent<ChangeThirdLight>().enabled = false;
        sliders[2].gameObject.GetComponent<ChangeThirdLight>().enabled = true;
    }
}
