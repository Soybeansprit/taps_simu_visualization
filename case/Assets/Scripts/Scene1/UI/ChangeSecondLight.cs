using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeSecondLight : MonoBehaviour
{
    public GameObject lightGroup;
    private Light[] lights;
    private bool isOn;

    void OnEnable()
    {
        isOn = false;
        lights = lightGroup.GetComponentsInChildren<Light>();
        gameObject.GetComponent<Slider>().value = SaveGameData.Instance.CurrentSecondLightIntensity;
        isOn = true;
    }

    // Start is called before the first frame update
    void Start()
    {
        isOn = true;
        lights = lightGroup.GetComponentsInChildren<Light>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnValueChanged()
    {
        if (isOn)
        {
            for (int i = 0; i < lights.Length; ++i)
            {
                lights[i].intensity = gameObject.GetComponent<Slider>().value;
            }
            SaveGameData.Instance.CurrentSecondLightIntensity = gameObject.GetComponent<Slider>().value;
        }    
    }
}
