using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondLightOn : MonoBehaviour
{
    private float intensity;
    private int waitTime;
    public GameObject LightGroup;
    private Light[] Light;
    private float tick;

    // Start is called before the first frame update
    void Start()
    {
        intensity = SaveGameData.Instance.NormalLightIntensity;
        waitTime = SaveGameData.Instance.WaitSecondGroupLightOn;
        tick = 0;
    }

    // Update is called once per frame
    void Update()
    {
        tick += Time.deltaTime;
        if (tick >= waitTime)
        {
            WaitLightOn();
        }
    }

    void WaitLightOn()
    {
        Light = LightGroup.GetComponentsInChildren<Light>();
        for (int i = 0; i < Light.Length; ++i)
        {
            Light[i].intensity = intensity;
        }
        SaveGameData.Instance.CurrentSecondLightIntensity = SaveGameData.Instance.NormalLightIntensity;
        tick = 0;
        gameObject.GetComponent<SecondLightOn>().enabled = false;
    }
}
