using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomColliderCheck : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider player)
    {
        if (player.tag == "Character")
        {
            if (SaveGameData.Instance.FirstGroupLightOn)
                gameObject.GetComponent<FirstLightOn>().enabled = true;
            if (SaveGameData.Instance.FirstGroupLightOff)
                gameObject.GetComponent<FirstLightOff>().enabled = false;
            if (SaveGameData.Instance.SecondGroupLightOn)
                gameObject.GetComponent<SecondLightOn>().enabled = true;
            if (SaveGameData.Instance.SecondGroupLightOff)
                gameObject.GetComponent<SecondLightOff>().enabled = false;
            if (SaveGameData.Instance.ThirdGroupLightOn)
                gameObject.GetComponent<ThirdLightOn>().enabled = true;
            if (SaveGameData.Instance.ThirdGroupLightOff)
                gameObject.GetComponent<ThirdLightOff>().enabled = false;
            if (SaveGameData.Instance.AirOn)
            {
                gameObject.GetComponent<AirOn>().enabled = true;
                GameObject.Find("AirMode").GetComponent<ShowAirMode>().enabled = true;
                GameObject.Find("DefaultTemperature").GetComponent<ShowDefaultTemperature>().enabled = true;
                GameObject.Find("Air").GetComponent<ShowTemperature>().enabled = true;
                GameObject.Find("Air1").GetComponent<ShowTemperature>().enabled = true;
            }
            if (SaveGameData.Instance.AirOff)
                gameObject.GetComponent<AirOff>().enabled = false;
            if (SaveGameData.Instance.CurtainOn)
                gameObject.GetComponent<CurtainOn>().enabled = true;
            if (SaveGameData.Instance.CurtainOff)
                gameObject.GetComponent<CurtainOff>().enabled = false;
        }
    }

    private void OnTriggerExit(Collider player)
    {
        if (player.tag == "Character")
        {
            if(SaveGameData.Instance.FirstGroupLightOn)
                gameObject.GetComponent<FirstLightOn>().enabled = false;
            if (SaveGameData.Instance.FirstGroupLightOff)
                gameObject.GetComponent<FirstLightOff>().enabled = true;
            if (SaveGameData.Instance.SecondGroupLightOn)
                gameObject.GetComponent<SecondLightOn>().enabled = false;
            if (SaveGameData.Instance.SecondGroupLightOff)
                gameObject.GetComponent<SecondLightOff>().enabled = true;
            if (SaveGameData.Instance.ThirdGroupLightOn)
                gameObject.GetComponent<ThirdLightOn>().enabled = false;
            if (SaveGameData.Instance.ThirdGroupLightOff)
                gameObject.GetComponent<ThirdLightOff>().enabled = true;
            if (SaveGameData.Instance.AirOn)
            {
                gameObject.GetComponent<AirOn>().enabled = false;
                GameObject.Find("AirMode").GetComponent<ShowAirMode>().enabled = false;
                GameObject.Find("CurrentTemperature").GetComponent<ShowCurrentTemperature>().enabled = false;
                GameObject.Find("DefaultTemperature").GetComponent<ShowDefaultTemperature>().enabled = false;
                GameObject.Find("空调").GetComponent<ShowTemperature>().enabled = false;
                GameObject.Find("空调1").GetComponent<ShowTemperature>().enabled = false;
            }
            if (SaveGameData.Instance.AirOff)
                gameObject.GetComponent<AirOff>().enabled = true;
            if (SaveGameData.Instance.CurtainOn)
                gameObject.GetComponent<CurtainOn>().enabled = false;
            if (SaveGameData.Instance.CurtainOff)
                gameObject.GetComponent<CurtainOff>().enabled = true;
        }
    }
}
