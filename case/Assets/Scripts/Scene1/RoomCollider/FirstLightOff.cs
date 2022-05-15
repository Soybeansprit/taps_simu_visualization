using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstLightOff : MonoBehaviour
{
    private int waitTime;
    public GameObject LightGroup;
    private Light[] Light;
    private float tick;

    // Start is called before the first frame update
    void Start()
    {
        waitTime = SaveGameData.Instance.WaitFirstGroupLightOff;
        tick = 0;
    }

    // Update is called once per frame
    void Update()
    {
        tick += Time.deltaTime;
        if (tick >= waitTime)
        {
            WaitLightOff();
        }
    }

    void WaitLightOff()
    {
        Light = LightGroup.GetComponentsInChildren<Light>();
        for (int i = 0; i < Light.Length; ++i)
        {
            Light[i].intensity = 0;
        }
        tick = 0;
        gameObject.GetComponent<FirstLightOff>().enabled = false;
    }
}
