using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirOn : MonoBehaviour
{
    private int temperature;
    private int waitTime;
    public GameObject[] Air;
    private TemperatureControl[] TemperatureControl;
    private float tick;

    // Start is called before the first frame update
    void Start()
    {
        waitTime = SaveGameData.Instance.WaitAirOn;
        tick = 0;
    }

    // Update is called once per frame
    void Update()
    {
        tick += Time.deltaTime;
        if (tick >= waitTime)
        {
            WaitAirOn();
        }
    }

    void WaitAirOn()
    {
        for(int i = 0; i < Air.Length; ++i)
        {
            TemperatureControl = Air[i].GetComponentsInChildren<TemperatureControl>();
            TemperatureControl[0].ChangeTemperature(SaveGameData.Instance.InitialTemperature);
            TemperatureControl[1].ChangeTemperature(SaveGameData.Instance.Temperature);
        }
        tick = 0;
        gameObject.GetComponent<AirOn>().enabled = false;
    }
}
