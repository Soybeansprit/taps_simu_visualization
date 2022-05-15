using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirOff : MonoBehaviour
{
    private int waitTime;
    public GameObject[] Air;
    private TemperatureControl[] TemperatureControl;
    private float tick;

    // Start is called before the first frame update
    void Start()
    {
        waitTime = SaveGameData.Instance.WaitAirOff;
        tick = 0;
    }

    // Update is called once per frame
    void Update()
    {
        tick += Time.deltaTime;
        if (tick >= waitTime)
        {
            WaitAirOff();
        }
    }

    void WaitAirOff()
    {
        for (int i = 0; i < Air.Length; ++i)
        {
            TemperatureControl = Air[i].GetComponentsInChildren<TemperatureControl>();
            for (int j = 0; j < TemperatureControl.Length; ++j)
            {
                TemperatureControl[j].default_value = 0;
            }
        }
        tick = 0;
        gameObject.GetComponent<AirOff>().enabled = false;
    }
}
